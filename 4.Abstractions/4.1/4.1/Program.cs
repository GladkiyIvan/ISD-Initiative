using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._1
{
    abstract class AbstractHandler
    {
        abstract public void Open() ;
        abstract public void Create() ;
        abstract public void Change() ;
        abstract public void Save() ;
    }
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XML - Open");
        }
        public override void Create()
        {
            Console.WriteLine("XML - Create");  
        }
        public override void Change()
        {
            Console.WriteLine("XML - Change");
        }
        public override void Save()
        {
            Console.WriteLine("XML - Save");
        }
    }
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
    
    class Program
    {
        static public void Determinator(AbstractHandler exemplar)
        {
            if (exemplar is XMLHandler)
            {
                exemplar.Open();
            }
            else if (exemplar is DocHandler)
            { 
                exemplar.Open();
            } 
            else if (exemplar is TXTHandler)
            {
                exemplar.Open();
            }
            else
            {
                Console.WriteLine("Wrong input.");
                return;
            }
        }

        static void Main(string[] args)
        {
            XMLHandler xmlFile = new XMLHandler();
            TXTHandler txtFile = new TXTHandler();
            DocHandler docFile = new DocHandler();
            
            Determinator(xmlFile);
            Determinator(txtFile);
            Determinator(docFile);
            Console.ReadKey();
        }
    }
}
