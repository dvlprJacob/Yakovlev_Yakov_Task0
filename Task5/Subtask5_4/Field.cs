﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask5_4
{
    class Field
    {
        int FinishX
        {
            set
            {
                if (value < Width && value > 0)
                    FinishX = value;
            }
            get
            {
                return FinishX;
            }
        }
        int FinishY
        {
            set
            {
                if (value < Height && value > 0)
                    FinishX = value;
            }
            get
            {
                return FinishY;
            }
        }
        int Height { set; get; }
        int Width { set; get; }
        Player player;
        Bonus[] bonus;
        Monster[] monster;
        public bool Win()
        {
            if (player.X == FinishX && player.Y == FinishY)//todo придирка, не обращать внимания: "Цель игры – собрать все бонусы и не быть «съеденным» монстрами.", а у тебя выигрыш - просто дойти до угла поля.
                return true;
            return false;
        }
    }
}

