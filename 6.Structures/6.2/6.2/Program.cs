using System;

namespace _6._2
{
    class Program
    {
        struct Train
        {
            public int trainNum;
            public string destinationPoint;
            public DateTime departureTime;

            public Train(int num, string dest, DateTime time)
            {
                trainNum = num;
                destinationPoint = dest;
                departureTime = time;
            }
            public void SetTrain()
            {
                string check;
                do
                {
                    Console.WriteLine("Set trains number: ");
                    check = Console.ReadLine();
                } while (!Int32.TryParse(check, out trainNum));
                Console.WriteLine("Set trains destination point: ");
                destinationPoint = Console.ReadLine();
                Console.WriteLine("Set trains departure time: ");
                string line = Console.ReadLine();
                while (!DateTime.TryParseExact(line, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out departureTime))
                {
                    Console.WriteLine("Invalid date, please retry");
                    line = Console.ReadLine();
                }
            }

            public void Out()
            {
                Console.WriteLine("Train with number " + trainNum + " left at " + departureTime + " and on the way to " + destinationPoint);
            }
        }


        static void SortTrains(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                for (int j = i; j < trains.Length; j++)
                {
                    if (trains[i].trainNum > trains[j].trainNum && i != j)
                    {
                        Train tmp = new Train(trains[i].trainNum, trains[i].destinationPoint, trains[j].departureTime);
                        trains[i] = trains[j];
                        trains[j] = tmp;
                    }
                }
            }
        }

        static void FindTrain(Train[] trains, int num)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].trainNum == num)
                {
                    trains[i].Out();
                    return;
                }
            }
            Console.WriteLine("There is no train with this number!");
        }
        static void Main(string[] args)
        {
            Train[] trains = new Train[8];
            string checkInput;
            Console.WriteLine("Set all trains: ");
            for (int i = 0; i < trains.Length; i++)
            {
                int j = i + 1;
                Console.WriteLine("Set " + j + " train");
                trains[i].SetTrain();
            }
            SortTrains(trains);
            do
            {
                Console.WriteLine("Do you want to find a train by its number? Press any key to find, or 0 to exit");
                checkInput = Console.ReadLine();
                if (checkInput != "0")
                {
                    int find;
                    string check;
                    do
                    {
                        Console.WriteLine("Set trains number You want to find: ");
                        check = Console.ReadLine();
                    } while (!Int32.TryParse(check, out find));
                    FindTrain(trains, find);
                }
            } while (checkInput != "0");
        }
    }
}
