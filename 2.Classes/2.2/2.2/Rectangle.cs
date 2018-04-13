namespace _2._2
{
    class Rectangle
    {
        // Поля
        private double side1;
        private double side2;
        // Конструктор
        public Rectangle(double s1, double s2)
        {
            side1 = s1;
            side2 = s2;
        }
        // Методы
        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }
        // Свойства
        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }
    }
}
