using System;
using System.Collections.Generic;
using System.Text;

namespace Termin4_prop
{
   public class Skladniki
    {
        public Skladniki(int welowodany, int tluszcz, int sol)
        {
            this.welowodany = welowodany;
            this.tluszcz = tluszcz;
            this.sol = sol;
        }

        public int welowodany { get; set; }
        public int tluszcz { get; set; }
        public int sol { get; set; }
    }
}
