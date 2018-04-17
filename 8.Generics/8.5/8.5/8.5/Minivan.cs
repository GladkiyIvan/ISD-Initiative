using System;

namespace _8._5
{
    class Minivan : ICar
    {
        public string Name { get; set; }
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

        public Minivan(string name, int year)
        {
            Name = name;
            Year = year;
        }

        public override string ToString()
        {
            return string.Format($"Тип        : минивен\nНазвание   : {Name}\nГод выпуска: {Year}");
        }
    }
}
