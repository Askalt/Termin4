using System;
using System.Collections.Generic;
using System.Text;

namespace Termin4_prop
{
   public class Hex
    {
        public Hex(string kod)
        {
            this.kod = kod;
        }

        public string kod { get; set; }

        public void Deconstruct(out string R, out string G, out string B)
        {
            R = kod[0].ToString() + kod[1].ToString();
            G = kod[2].ToString() + kod[3].ToString()+kod[4].ToString();
            B = kod[5].ToString() + kod[6].ToString();

        }

        //public void Deconstruct(out int R,out int G,out int B)
        //{
        //    R = Convert.ToInt32(kod.Substring(0, 2), 16);
        //    G = Convert.ToInt32(kod.Substring(2, 2), 16);
        //    B = Convert.ToInt32(kod.Substring(4, 2), 16);
        //}
    }
}
