using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._1
{ 
    class Program
    {
        static public void Determinator(AbstractHandler exemplar)
        {
            if (exemplar is XMLHandler)
            {
                Console.WriteLine("It's XML . XML-methods :"); 
                exemplar.Open();
            }
            else if (exemplar is DocHandler)
            {
                Console.WriteLine("It's Doc . Doc-methods :");
                exemplar.Open();
            } 
            else if (exemplar is TXTHandler)
            {
                Console.WriteLine("It's TXT . TXT-methods :");
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
