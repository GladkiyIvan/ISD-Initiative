using System;

namespace _7._3
{
    delegate int MyDelegate(int x);

    class Program
    {
        static Random rnd = new Random();

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
                Console.Write("Три случайных числа   : ");

                anonymous(delegates);

                Console.WriteLine("\nНажмите, чтобы продолжить...");
                Console.ReadKey();
                Console.WriteLine("------------------------------");
            }
        }

        static Action<MyDelegate[]> anonymous = (delegates) =>
        {
            double sum = 0;
            foreach (MyDelegate d in delegates)
            {
                int invokationResult = d.Invoke(9);
                sum += invokationResult;
                Console.Write(invokationResult + " ");
            }
            Console.WriteLine("\nСреднее арифметическое: " + (sum / delegates.Length).ToString("F"));
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
