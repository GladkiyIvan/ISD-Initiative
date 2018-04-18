using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._1
{
    class DocHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOC - Open");
        }
        public override void Create()
        {
            Console.WriteLine("DOC - Create");
        }
        public override void Change()
        {
            Console.WriteLine("DOC - Change");
        }
        public override void Save()
        {
            Console.WriteLine("DOC - Save");
        }
    }
}
