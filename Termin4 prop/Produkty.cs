using System;
using System.Collections.Generic;
using System.Text;

namespace Termin4_prop
{
   public class Produkty
    {
       public  List<Skladniki> list = new List<Skladniki>();

        public Produkty(List<Skladniki> list)
        {
            this.list = list;
        }
    }
}
