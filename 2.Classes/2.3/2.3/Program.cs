using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book mybook;

            Title newtitle = new Title();
            Console.Write("Введите название книги: ");
            newtitle.MyTitle = Console.ReadLine();

            Console.CursorTop++;

            Author newauthor = new Author();
            Console.Write("Введите имя автора: ");
            newauthor.MyAuthor = Console.ReadLine();

            Console.CursorTop++;

            Content newcontent = new Content();
            Console.Write("Введите содержание книги: ");
            newcontent.MyContent = Console.ReadLine();

            mybook = new Book(newtitle, newauthor, newcontent);

            Console.CursorTop++;

            mybook.Show();
            Console.ReadKey();
        }
    }
}
