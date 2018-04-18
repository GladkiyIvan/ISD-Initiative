using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._1
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT - Open");
        }
        public override void Create()
        {
            Console.WriteLine("TXT - Create");
        }
        public override void Change()
        {
            Console.WriteLine("TXT - Change");
        }
        public override void Save()
        {
            Console.WriteLine("TXT - Save");
        }
    }
}
