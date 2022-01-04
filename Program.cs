using System;

using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{

    enum Buff {Speed, Invisibility, Saturation  }
    enum Debuff {Slownes, Blindness, Hunger }
   
    class Player   {
       public Point Coardinates { get; set; }
        public int Helth { get; set; }
        public bool IsAlive { get; set; }

       public List<Buff> Buffs = new List<Buff>();
       public List<Debuff> Debuffs = new List<Debuff>();

        public static int operator+ (Player left)
        {
            if(left.Helth<100 && left.Helth+10<=100)
            { 
            left.Helth+=10; 
            }
            return left.Helth;
        } 
        public static int operator- (Player left)
        {
            if(left.Helth>0 && left.Helth-10>=0)
            { 
            left.Helth-=10; 
            }
            return left.Helth;
        }

        public void AddBuff(Buff buff)
        {Buffs.Add(buff);}

        public void AddDebuff(Debuff  debuff)
        {  Debuffs.Add(debuff);} 
        public void RemoveBuff(Buff buff) {Buffs.Remove(buff);} 
        public void RemoveDebuff(Debuff  debuff) {Buffs.Remove(debuff); }

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

            Player Kek= new Player(); 
            Player Ke= new Player(); 

          int valu = +Ke;
            valu = +Ke;
            valu=-Ke;
           
           

            Console.WriteLine(valu); 

            Console.ReadLine();
             
        }
    }
}