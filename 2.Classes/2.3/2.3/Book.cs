using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Book
    {
        private Title title = new Title();
        private Author author = new Author();
        private Content content = new Content();

        public Book (Title newtitle, Author newauthor, Content newcontent)
        {
            title = newtitle;
            author = newauthor;
            content = newcontent;
        }

        public void Show()
        {
            Console.CursorTop++;
            title.Show();
            Console.CursorTop++;
            author.Show();
            Console.CursorTop++;
            content.Show();
        }
    }
}
