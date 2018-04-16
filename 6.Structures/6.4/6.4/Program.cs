using System;

namespace _6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Узнайте, сколько осталось до вашего Дня рождения!");
                Console.WriteLine("-------------------------------------------------");

                Console.WriteLine("\nКогда вы родились?");
                Console.Write("День:  ");
                if (!int.TryParse(Console.ReadLine(), out int day))
                {
                    ShowError();
                    continue;
                }
                Console.Write("Месяц: ");
                if (!int.TryParse(Console.ReadLine(), out int month))
                {
                    ShowError();
                    continue;
                }
                Console.Write("Год:   ");
                if (!int.TryParse(Console.ReadLine(), out int year))
                {
                    ShowError();
                    continue;
                }

                DateTime birthday;
                try
                {
                    birthday = new DateTime(year, month, day);
                }
                catch
                {
                    ShowError();
                    continue;
                }

                Console.WriteLine("\nВаш день рождения: " + birthday.ToLongDateString() + "\n");

                GetNextBirthday(year, month, day);

                Console.WriteLine("\nНажмите, чтобы продолжить...");

                Console.ReadKey();

                Console.Clear();
            }
        }

        static void GetNextBirthday(int year, int month, int day)
        {
            int yearOfNextBDay;

            if (DateTime.Now.Month > month)
            {
                yearOfNextBDay = DateTime.Now.Year + 1;
            }
            else if (DateTime.Now.Month < month)
            {
                yearOfNextBDay = DateTime.Now.Year;
            }
            else
            {
                if (DateTime.Now.Day > day)
                {
                    yearOfNextBDay = DateTime.Now.Year + 1;
                }
                else
                {
                    yearOfNextBDay = DateTime.Now.Year;
                }
            }

            int age = yearOfNextBDay - year;

            DateTime nextBirthday = new DateTime(yearOfNextBDay, month, day);

            TimeSpan timeSpan = nextBirthday.Subtract(DateTime.Now);

            Console.WriteLine($"До следующего Деня рождения ({nextBirthday.ToLongDateString()}) осталось {timeSpan.Days} дней, вам исполнится {age} лет");
        }
        static void ShowError()
        {
            Console.Clear();
            Console.WriteLine("Ошибка ввода!");
            Console.WriteLine("\nНажмите, чтобі продолжить...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
