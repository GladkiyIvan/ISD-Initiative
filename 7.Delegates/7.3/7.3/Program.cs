using System;

namespace _7._3
{
    delegate int MyDelegate(int x);
    
    class Program
    {
        static  Random rnd = new Random();
        static string output;

        static void Main(string[] args)
        {
            MyDelegate[] delegates =
            {
                new MyDelegate(FirstMethod),
                new MyDelegate(SecondMethod),
                new MyDelegate(ThirdMethod)
            };

            while (true)
            {
                output = "Три случайных числа   : ";

                anonymous(delegates);

                Console.WriteLine(output);

                Console.WriteLine("\nНажмите, чтобы продолжить...");
                Console.ReadKey();
                Console.WriteLine("------------------------------");
            }
        }

        static Func<MyDelegate[], int> anonymous = (delegates) =>
        {
            int temp = 0;
            foreach (MyDelegate d in delegates)
            {
                int invokationResult = d.Invoke(9);
                temp += invokationResult;
                output += invokationResult + " ";
            }
            double result = (double)temp / (double)delegates.Length;
            output += "\nСреднее арифметическое: " + Math.Round(result);
            return temp;
        };

        static int FirstMethod(int x)
        {
            return rnd.Next(x);
        }
        static int SecondMethod(int x)
        {
            return rnd.Next(x);
        }
        static int ThirdMethod(int x)
        {
            return rnd.Next(x);
        }
    }
}
