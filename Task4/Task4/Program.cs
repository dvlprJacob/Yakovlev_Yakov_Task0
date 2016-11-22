﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Round//todo классы принято выносить в отдельные файлы
    {
        int x; //todo для этого поля у тебя не предусмотрено никаких проверок, соответственно его можно заменить на свойство
        int y;//todo для этого поля у тебя не предусмотрено никаких проверок, соответственно его можно заменить на свойство
        int R;
        public Round()
        {
            this.x = 0;
            this.y = 0;
            this.R = 0;
        }
        public Round(int x,int y,int R)
        {
            this.x = x;
            this.y = y;
            this.R = R;
        }
        public void SetCoor(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public int Radius
        {
            get
            {
                return R;
            }
            set
            {
                if (value >= 0)
                    R = value;
            }
        }
        public int X //todo сократить запись этого свойства до get; set;
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y//todo сократить запись этого свойства до get; set;
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public double Area
        {
            get
            {
                if (R == 0)
                    return 0;
                return Math.PI * R * R;
            }

        }
        public double L
        {
            ///<summary>
            ///property returns the length of the circumscribed circle
            ///</summary>
            get
            {
                return 2 * Math.PI * R;
            }
        }
        public override string ToString() //todo ты просто скрыл базовую реализацию метода, лучше писать через override (по методологии ООП)
        {
            return "Round with center in (" + x.ToString() + ";" + y.ToString() + ")  and radius equall " + R.ToString();
        }
        public void Write()
        {
            Console.WriteLine(this.ToString());
            return;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Round F = new Round(0, 0, 1);
            Console.WriteLine(F);
            F.Write();
            Console.WriteLine("Area equall {0}\nLength of the circumscribed circle equall {1}\nPress any key for ap clossing . . . ", F.Area,F.L);
            Console.ReadKey();
            return;
        }
    }
}
