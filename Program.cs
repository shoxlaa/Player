using System;

using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{

    enum Buff { }
    enum Debuff { }

    class Player
    {
         public Point Coardinates { get; set; }
        public uint Helth { get; set; }
        public bool IsAlive { get; set; }

        List<Buff> Buffs = new List<Buff>();
        List<Debuff> Debuffs = new List<Debuff>();

    }
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

    class Program
    {
        static void Main(string[] args)
        {



        }
    }
}