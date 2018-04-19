using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("Three Rings for the Elven-kings under the sky,");
            myList.Add("Seven for the Dwarf-lords in their halls of stone,");
            myList.Add("Nine for Mortal Men doomed to die,");
            myList.Add("One for the Dark Lord on his dark throne");
            myList.Add("In the Land of Mordor where the Shadows lie.");
            myList.Add("One Ring to rule them all, One Ring to find them,");
            myList.Add("One Ring to bring them all and in the darkness bind them");
            myList.Add("In the Land of Mordor where the Shadows lie....");

            Console.ForegroundColor = ConsoleColor.Red;

            foreach(string quote in myList)
            {
                Console.WriteLine(quote);
            }

            Console.ReadKey();
        }
    }
}
