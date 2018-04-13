using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Content
    {
        private string content;

        public string SetContent
        {
            get
            {
                return content;
            }
            set
            {
                if (value != "")
                {
                    content = value;
                }
                else
                {
                    Console.WriteLine("Введена пустая строка, значение установленно по умолчанию.");
                    content = "*пусто*";
                }
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Содержание книги: {SetContent}");
        }
    }
}
