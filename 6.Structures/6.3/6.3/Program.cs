using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6._3
{
    class MyClass
    {
        public string change;
    }
    struct MyStruct
    {
        public string change;
    }
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Class was Changed ";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "Struct was Changed";
        }
        static void Main(string[] args)
        {
            MyStruct abc ;
            MyClass xyz = new MyClass();
            abc.change = "Struct was not changed";
            xyz.change = "Class was not changed";
            StructTaker(abc);
            ClassTaker(xyz);
            Console.WriteLine("Struct :" + abc.change);
            Console.WriteLine("Class :" + xyz.change);
            Console.ReadKey();
            /*
            Структура передается как копия из-за того что это ValueType и ,когда ф-ция заканчивает свою 
            работу ,копия уничтожается поэтому результат не меняется ,а класс хранится в памяти иначе и
            при передачи класса передается ссылка на оригинал объекта и обрабатывается именно оригинал 
            поэтому значение класса меняется.
             */
        }
    }
}
