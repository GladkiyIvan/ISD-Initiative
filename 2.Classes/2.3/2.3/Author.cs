using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Author
    {
        private string author;

        public string SetAuthor
        {
            get
            {
                return author;
            }
            set
            {
                if (value != "")
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Введена пустая строка, значение установленно по умолчанию.");
                    author = "*пусто*";
                }
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Имя автора: {SetAuthor}");
        }
    }
}
