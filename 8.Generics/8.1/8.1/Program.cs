using System;

namespace _8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(126, 26);

            Console.WriteLine("Метод MyClass<T>.Factory(params object[] args)");

            Console.WriteLine("\n" + new string('-', 126));

            int i;
            try
            {
                i = MyClass<int>.FactoryMethod();
                Console.WriteLine("Тип, полученый в результате операции MyClass<int>.FactoryMethod().............................." + i.GetType().ToString() + "\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
                Console.WriteLine("Вероятно, вы пытались создать экземпляр типа, передавая его специальному конструктору некорректные параметры");
            }

            string s;
            try
            {
                s = MyClass<string>.FactoryMethod('a', 1);
                Console.WriteLine("Тип, полученый в результате операции MyClass<string>.FactoryMethod('a', 1)....................." + s.GetType().ToString() + "\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
                Console.WriteLine("Вероятно, вы пытались создать экземпляр типа, передавая его специальному конструктору некорректные параметры");
            }

            ClassWithOnlyDefaultCtor defaultCtor;
            try
            {
                defaultCtor = MyClass<ClassWithOnlyDefaultCtor>.FactoryMethod();
                Console.WriteLine("Тип, полученый в результате операции MyClass<ClassWithOnlyDefaultCtor>.FactoryMethod()........." + defaultCtor.GetType().ToString() + "\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
                Console.WriteLine("Вероятно, вы пытались создать экземпляр типа, передавая его специальному конструктору некорректные параметры");
            }

            ClassWithoutDefaultCtor withoutDefaultCtor;
            try
            {
                withoutDefaultCtor = MyClass<ClassWithoutDefaultCtor>.FactoryMethod("a", 1);
                Console.WriteLine("Тип, полученый в результате операции MyClass<ClassWithoutDefaultCtor>.FactoryMethod('a', 1)...." + withoutDefaultCtor.GetType().ToString() + "\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
                Console.WriteLine("Вероятно, вы пытались создать экземпляр типа, передавая его специальному конструктору некорректные параметры");
            }

            Console.WriteLine("Сообщение об ошибке, полученное в результате операции MyClass<int>.FactoryMethod('five'): ");
            int wrongCtorParams;
            try
            {
                wrongCtorParams = MyClass<int>.FactoryMethod("five");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
                Console.WriteLine("Вероятно, вы пытались создать экземпляр типа, передавая его специальному конструктору некорректные параметры");
            }

            Console.ReadKey();
        }
    }
}
