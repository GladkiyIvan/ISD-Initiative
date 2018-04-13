using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Title
    {
        private string title;

        public string SetTitle
        {
            get
            {
                return title;
            }
            set
            {
                if (value != "")
                {
                    title = value;
                }
                else
                {
                    Console.WriteLine("Введена пустая строка, значение установленно по умолчанию.");
                    title = "*пусто*";
                }
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Название книги: {SetTitle}");
        }
    }
}
