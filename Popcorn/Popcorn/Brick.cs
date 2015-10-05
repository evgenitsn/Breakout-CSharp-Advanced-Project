﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popcorn
{
    public class Brick : GameObject, IDestroyable
    {
        private const char symbol = '#';
        public const int STENGHT = 1;
        public new const bool isDestroyable = true;
        public int Size { get; set; }

        public virtual int GetBonus()
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }

        public override char GetCharOfObject()
        {
            return symbol;
        }
    }

}
