﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popcorn
{
    class EmptyBlock : GameObject
    {
        private const char symbolForPrinting = ' ';

        public override char GetCharOfObject()
        {
            return symbolForPrinting;
        }
    }
}