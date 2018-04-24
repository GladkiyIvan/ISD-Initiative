using System;

namespace _8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 25);

            Console.WriteLine("Метод MyClass<T>.Factory(params object[] args):");
            Console.WriteLine("\n - если при вызове метода ему не передаются параметры и Т не является ссылочным типом, то метод вернёт\n    значение по умолчанию для типа Т;");
            Console.WriteLine("\n - если необходимо создать экземпляр типа через пользовательский конструктор, аргументы метода должны\n    соответствовать параметрам интересующего пользовательского конструктора;");
            Console.WriteLine("\n - при попытке передачи в параметрах аргументов, не соответствующих ни одному из пользовательских конструкторов\n    типа, возникшее исключение будет обработано.");

            Console.WriteLine("\n" + new string('-', 120));

            int i = MyClass<int>.FactoryMethod();
            Console.WriteLine("Тип, полученый в результате операции MyClass<int>.FactoryMethod()........................" + i.GetType().ToString() + "\n");

            string s = MyClass<string>.FactoryMethod('a', 1);
            Console.WriteLine("Тип, полученый в результате операции MyClass<string>.FactoryMethod()....................." + s.GetType().ToString() + "\n");

            ClassWithOnlyDefaultCtor defaultCtor = MyClass<ClassWithOnlyDefaultCtor>.FactoryMethod();
            Console.WriteLine("Тип, полученый в результате операции MyClass<ClassWithOnlyDefaultCtor>.FactoryMethod()..." + defaultCtor.GetType().ToString() + "\n");

            ClassWithoutDefaultCtor withoutDefaultCtor = MyClass<ClassWithoutDefaultCtor>.FactoryMethod("a", 1);
            Console.WriteLine("Тип, полученый в результате операции MyClass<ClassWithoutDefaultCtor>.FactoryMethod()...." + withoutDefaultCtor.GetType().ToString() + "\n");

            int wrongCtorParams = MyClass<int>.FactoryMethod("five");

            Console.ReadKey();
        }
    }
}
