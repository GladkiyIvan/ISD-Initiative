using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Content
    {
        private string mycontent;

        public string MyContent
        {
            get
            {
                return mycontent;
            }
            set
            {
                if (value != "")
                {
                    mycontent = value;
                }
                else
                {
                    Console.WriteLine("Введена пустая строка, значение установленно по умолчанию.");
                    mycontent = "*пусто*";
                }
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Содержание книги: {MyContent}");
        }
    }
}
