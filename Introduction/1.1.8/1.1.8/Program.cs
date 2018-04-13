using System;

namespace _1._1._8
{
    class Program
    {
        const int startBalance = 1000;
        static int balance = startBalance;

        static void Main(string[] args)
        {
            ShowUI();

            Console.ReadKey();
        }
        static void NextRound()
        {
            Console.Clear();

            Console.WriteLine($"Ваш баланс: {balance}");
            Console.WriteLine("-----------------------\n");
            
            Console.Write("Сделайте вашу ставку: ");
            if (int.TryParse(Console.ReadLine(), out int bet))
            {
                if (bet > balance)
                    ShowError(2);
                if (bet <= 0)
                    ShowError(3);

                Random rnd = new Random();

                Console.WriteLine("Бросаю кубик...");
                System.Threading.Thread.Sleep(500);

                balance -= bet;

                int number = rnd.Next(1, 13);
                Console.WriteLine($"Выпало число {number}");
                if(number >= 1 && number <= 5)
                {
                    Console.WriteLine(" - вы проиграли!");

                    if (balance < 0)
                        ShowStat();
                }
                else if(number >= 6 && number <= 8)
                {
                    Console.WriteLine(" - ваша ставка остаётся при вас!");
                    balance += bet;
                }
                else if(number >= 9 && number <= 11)
                {
                    Console.WriteLine($" - вы выиграли {bet * 2}!");
                    balance += bet * 2;
                }
                else
                {
                    Console.WriteLine($" - джекпот {bet * 10}!");
                    balance += bet * 10;
                }

                Console.WriteLine("-----------------------");
                Console.WriteLine("Нажмите любую клавишу...");
                Console.ReadKey();

                ShowUI();
            }
            else
            {
                ShowError(1);
            }
        }
        static void SelectAction()
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int select) && input.Length == 1)
            {
                if (select == 0)
                {
                    ShowStat();

                    Console.WriteLine("Нажмите любую клавишу...");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (select == 1)
                {
                    NextRound();
                }
                else if(select == 2)
                {
                    ShowRules();
                }
                else
                {
                    ShowError(1);
                }
            }
            else
            {
                ShowError(1);
            }
        }
        static void ShowUI()
        {
            Console.Clear();

            Console.WriteLine($"Ваш баланс: {balance}");
            Console.WriteLine("-----------------------\n");

            Console.WriteLine("Меню:");
            Console.WriteLine(" 1. Сделать ставку");
            Console.WriteLine(" 2. Правила");
            Console.WriteLine(" 0. Выйти");
            Console.Write("Ввод: ");

            SelectAction();
        }
        static void ShowError(int errorCode)
        {
            Console.Clear();
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

            if (errorCode == 1)
                Console.WriteLine("Ошибка ввода");
            if (errorCode == 2)
                Console.WriteLine("Ставка не может превышать баланс");
            if (errorCode == 3)
                Console.WriteLine("Ставка должна быть положительным числом");

            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            ShowUI();
        }
        static void ShowStat()
        {
            int profit = balance - startBalance;

            Console.Clear();

            Console.WriteLine("-----------------------");
            Console.WriteLine($"Ваш баланс: {balance}");
            if(profit > 0)
                Console.WriteLine($"Результат: +{profit}");
            else
                Console.WriteLine($"Результат: {profit}");
            Console.WriteLine("-----------------------");
        }
        static void ShowRules()
        {
            Console.Clear();

            Console.WriteLine("-----------------------");

            Console.WriteLine("Кубик имеет 12 граней\n" +
                              "1-5  - проигрыш\n" + 
                              "6-8  - ставка возвращается\n" +
                              "9-11 - ставка удваивается\n" +
                              "12   - ставка умножается на 10");

            Console.WriteLine("-----------------------");
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();

            ShowUI();
        }
    }
}