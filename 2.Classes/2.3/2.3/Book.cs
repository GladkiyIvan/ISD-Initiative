using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Book
    {
        private Title title;
        private Author author;
        private Content content;

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
