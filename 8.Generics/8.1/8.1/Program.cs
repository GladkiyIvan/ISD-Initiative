using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = MyClass<int>.FacrotyMethod();
            Console.WriteLine($"Значение по умолчанию для типа int: {myInt}");
            double myDouble = MyClass<double>.FacrotyMethod();
            Console.WriteLine($"Значение по умолчанию для типа double: {myDouble}");
            string myString = MyClass<string>.FacrotyMethod();
            Console.WriteLine($"Значение по умолчанию для типа string: {myString}");
            Object myObject = MyClass<Object>.FacrotyMethod();
            Console.WriteLine($"Значение по умолчанию для типа object: {myObject}");
            Console.ReadKey();
        }
    }
}
