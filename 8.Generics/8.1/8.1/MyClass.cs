using System;

namespace _8._1
{
    static class MyClass<T>
    {
        public static T FactoryMethod(params object[] args)
        {
            if (args.Length == 0 && default(T) != null)
            {
                return default(T);
            }
            else
            {
                try
                {
                    return (T)Activator.CreateInstance(typeof(T), args);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
                    Console.WriteLine("Вероятно, вы пытались создать экземпляр типа, передавая его специальному конструктору некорректные параметры");
                    if(default(T) == null)
                        Console.WriteLine("Метод вернул null");
                    else
                        Console.WriteLine("Метод вернул " + default(T));
                    return default(T);
                }
            }
        }
    }
}
