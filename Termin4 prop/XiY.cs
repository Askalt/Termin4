﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Termin4_prop
{
    class XiY
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void WGore(object sender,EventArgs e)
        {
            Y++;
            Console.WriteLine($"X:{X} Y:{Y}");
        }
        public void WDol(object sender ,EventArgs e)
        {
            Y--;
            Console.WriteLine($"X:{X} Y:{Y}");
        }
        public void WLewo(object sender,EventArgs e)
        {
            X++;
            Console.WriteLine($"X:{X} Y:{Y}");
        }
        public void WPrawo(object sender ,EventArgs e)
        {
            X--;
            Console.WriteLine($"X:{X} Y:{Y}");
        }


    }
}
