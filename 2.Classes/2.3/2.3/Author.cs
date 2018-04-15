using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Author
    {
        private string myauthor;

        public string MyAuthor
        {
            get
            {
                return myauthor;
            }
            set
            {
                if (value != "")
                {
                    myauthor = value;
                }
                else
                {
                    Console.WriteLine("Введена пустая строка, значение установленно по умолчанию.");
                    myauthor = "*пусто*";
                }
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Имя автора: {MyAuthor}");
        }
    }
}
