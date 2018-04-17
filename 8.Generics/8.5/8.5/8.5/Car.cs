using System;

namespace _8._5
{
    class Car : ICar
    {
        public string Name { get; set ; }
        int year;
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1806)
                    year = 1806;
                else if (value > DateTime.Now.Year)
                    year = DateTime.Now.Year;
                else
                    year = value;
            }
        }

        public Car(string name, int year)
        {
            Name = name;
            Year = year;
        }

        public override string ToString()
        {
            return string.Format($"Тип        : легковой автомобиль\nНазвание   : {Name}\nГод выпуска: {Year}");
        }
    }
}
