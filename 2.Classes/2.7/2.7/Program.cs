using System;
using System.Collections.Generic;

namespace _2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee("Акакий", "Аманов", Position.Junior, 1),
                new Employee("Богдан", "Борсуков", Position.Middle, 2),
                new Employee("Виталий", "Виташин", Position.Senior, 3)
            };

            foreach(Employee e in employees)
                Console.WriteLine(e);

            Console.ReadKey();
        }
    }
}
