using System;

namespace _8._1
{
    static class MyClass<T>
    {
        public static T FactoryMethod(params object[] args)
        {
            return (T)Activator.CreateInstance(typeof(T), args);
        }
    }
}
