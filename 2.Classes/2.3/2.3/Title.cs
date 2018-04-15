using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Title
    {
        private string mytitle;

        public string MyTitle
        {
            get
            {
                return mytitle;
            }
            set
            {
                if (value != "")
                {
                    mytitle = value;
                }
                else
                {
                    Console.WriteLine("Введена пустая строка, значение установленно по умолчанию.");
                    mytitle = "*пусто*";
                }
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Название книги: {MyTitle}");
        }
    }
}
