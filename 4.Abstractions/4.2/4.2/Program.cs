using System;

namespace _4._2
{
    class Program
    {
        // вызов интерфейсных методов см. в методах ShowPlayUI() и ShowRecordUI()
        static void Main(string[] args)
        {
            SetConsoleStyle();

            Player player = new Player();

            ShowUI(player);

            Console.ReadKey();
        }

        static void SetConsoleStyle()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(35, 9);
        }
        static void ShowUI(Player player)
        {
            Console.Clear();

            int cursorPosition = 2;

            string[] menu =
                {
                    "  Воспроизвести  ",
                    "    Записать     "
                };
            
            while (true)
            {
                Console.SetCursorPosition(0, 0);

                Console.WriteLine("------------  MyPlayer  -----------\n");

                GetMenu(cursorPosition, 2, menu);

                Console.WriteLine("\n\n-------------------------------------");
                Console.WriteLine("Статус: выбор режима");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Enter:
                        if (cursorPosition == 2)
                            ShowPlayUI(player);
                        else if (cursorPosition == 3)
                            ShowRecordUI(player);
                        return;
                    case ConsoleKey.DownArrow:
                        cursorPosition++;
                        cursorPosition = SetCursorPosition(2, 3, cursorPosition);
                        break;
                    case ConsoleKey.UpArrow:
                        cursorPosition--;
                        cursorPosition = SetCursorPosition(2, 3, cursorPosition);
                        break;
                }
            }
        }
        static void ShowPlayUI(Player player)
        {
            string[] menu =
            {
                "  Воспроизвести  ",
                "      Пауза      ",
                "      Стоп       ",
                "      Назад      "
            };

            int cursorPosition = 2;

            string status = "stop";
            while (true)
            {
                Console.Clear();

                Console.SetCursorPosition(0, 0);

                Console.WriteLine("------  Режим проигрывателя  ------\n");

                GetMenu(cursorPosition, 2, menu);

                Console.WriteLine("-------------------------------------");
                if(status == "play")
                    ((IPlayable)player).Play();
                else if(status == "pause")
                    ((IPlayable)player).Pause();
                else
                    ((IPlayable)player).Stop();
                
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Enter:
                        if (cursorPosition == 2)
                        {
                            ((IPlayable)player).Play();
                            status = "play";
                        }
                        else if (cursorPosition == 3)
                        {
                            ((IPlayable)player).Pause();
                            status = "pause";
                        }
                        else if (cursorPosition == 4)
                        {
                            ((IPlayable)player).Stop();
                            status = "stop";
                        }
                        else
                            ShowUI(player);
                        break;
                    case ConsoleKey.DownArrow:
                        cursorPosition++;
                        cursorPosition = SetCursorPosition(2, 5, cursorPosition);
                        break;
                    case ConsoleKey.UpArrow:
                        cursorPosition--;
                        cursorPosition = SetCursorPosition(2, 5, cursorPosition);
                        break;
                }
            }  
        }
        static void ShowRecordUI(Player player)
        {
            string[] menu =
            {
                "      Запись     ",
                "      Пауза      ",
                "      Стоп       ",
                "      Назад      "
            };
            int cursorPosition = 2;

            string status = "stop";
            while (true)
            {
                Console.Clear();

                Console.SetCursorPosition(0, 0);
                
                Console.WriteLine("--------  Режим рекордера  --------\n");

                GetMenu(cursorPosition, 2, menu);

                Console.WriteLine("-------------------------------------");
                if (status == "rec")
                    ((IRecodable)player).Record();
                else if (status == "pause")
                    ((IRecodable)player).Pause();
                else
                    ((IRecodable)player).Stop();

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Enter:
                        if (cursorPosition == 2)
                        {
                            ((IRecodable)player).Record();
                            status = "rec";
                        }
                        else if (cursorPosition == 3)
                        {
                            ((IRecodable)player).Pause();
                            status = "pause";
                        }
                        else if (cursorPosition == 4)
                        {
                            ((IRecodable)player).Stop();
                            status = "stop";
                        }
                        else
                            ShowUI(player);
                        break;
                    case ConsoleKey.DownArrow:
                        cursorPosition++;
                        cursorPosition = SetCursorPosition(2, 5, cursorPosition);
                        break;
                    case ConsoleKey.UpArrow:
                        cursorPosition--;
                        cursorPosition = SetCursorPosition(2, 5, cursorPosition);
                        break;
                }
            }
        }

        static void PaintString(string s)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static int SetCursorPosition(int min, int max, int current)
        {
            if (current == max + 1)
                return min;
            else if (current == min - 1)
                return max;
            else
                return current;
        }
        static void GetMenu(int cursorPosition, int offsetFromTop, params string[] menuItems)
        {
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.Write("         ");
                if (i + offsetFromTop == cursorPosition)
                    PaintString(menuItems[i]);
                else
                    Console.WriteLine(menuItems[i]);
            }
        }
    }
}