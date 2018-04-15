namespace _2._4
{
    class Point
    {
        public int X { get; }
        public int Y { get; }
        public string Name { get; }
        public Point()
        {
            X = 0;
            Y = 0;
            Name = "None";
        }
        public Point(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }
}
