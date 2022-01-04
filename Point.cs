namespace ConsoleApp1
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }


        public static Point operator +(Point left, Point right)
        {
            return new Point
            {
                X = left.X + right.X,
                Y = left.Y + right.Y
            };

        }

        public static Point operator -(Point left, Point right)
        {

            return new Point
            {
                X = left.X - left.X,
                Y = left.Y - left.Y
            };
        }

    }
}