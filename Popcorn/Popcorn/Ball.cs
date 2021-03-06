﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popcorn
{
    public class Ball : GameObject
    {
        public const char symbol = '@';
        public int Row { get; set; }
        public int Col { get; set; }
        public int UpdateRow { get; set; }
        public int UpdateCol { get; set; }

        public override bool IsDestroyable
        {
            get
            {
                return false;
            }

            
        }

        public Ball(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.UpdateCol = 1;
            this.UpdateRow = -1;
        }

        public override char GetCharOfObject()
        {
            return symbol;
        }
    }
}
