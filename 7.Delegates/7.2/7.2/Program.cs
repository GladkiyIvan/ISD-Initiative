using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    class Program
    {
        delegate bool CheckDelegate(double x);
        delegate string OutputDelegate(double x, double y);
        static void Main(string[] args)
        {


            double firstNum = Check("Введите первую цифру: ", x => false);
            Console.CursorTop++;
            double secondNum = Check("Введите вторую цифру: ", x => false);
            Console.CursorTop++;
            int operation = (int)Check("Выберите операцию (1 - Add, 2 - Sub, 3 - Mul, 4- Div): ", x => x <= 0 || x >= 5 || x % 1 != 0);
            Console.CursorTop++;

            OutputDelegate myDelegate;

            switch (operation)
            {
                case 1:
                    myDelegate = (x, y) => Convert.ToString(x + y);
                    Console.WriteLine($"Сложение ваших чисел = {myDelegate(firstNum, secondNum)}");
                    break;
                case 2:
                    myDelegate = (x, y) => Convert.ToString(x - y);
                    Console.WriteLine($"Вычитание ваших чисел = {myDelegate(firstNum, secondNum)}");
                    break;
                case 3:
                    myDelegate = (x, y) => Convert.ToString(x * y);
                    Console.WriteLine($"Умножение ваших чисел = {myDelegate(firstNum, secondNum)}");
                    break;
                case 4:
                    myDelegate = (x, y) =>
                    {
                        if (y == 0)
                        {
                            return "ошибка";
                        }
                        else
                        {
                            return Convert.ToString(x / y);
                        }
                    };
                    Console.WriteLine($"Деление ваших чисел = {myDelegate(firstNum, secondNum)}");
                    break;
            }

            Console.ReadKey();
        }

        static double Check(string invitation, CheckDelegate del)
        {
            while (true)
            {
                Console.Write(invitation);
                if (!double.TryParse(Console.ReadLine(), out double var) || del(var))
                {
                    Console.WriteLine("Некорректный вводю Попробуйте еще раз!");
                    continue;
                }
                return var;
            }
        }
    }
}
