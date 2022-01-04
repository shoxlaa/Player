using System.Collections.Generic;

namespace ConsoleApp1
{
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
        public void RemoveDebuff(Debuff  debuff) { Debuffs.Remove(debuff); }

    }
}