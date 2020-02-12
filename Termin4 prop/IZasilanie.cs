using System;
using System.Collections.Generic;
using System.Text;

namespace Termin4_prop
{
    interface IZasilanie
    {
        public void zasilaj(int energia);
    }
    public class PanelSloneczny : IZasilanie
    {
        public void zasilaj(int energia)
        {
            DateTime czas = DateTime.Now;
            
            if (energia<100&czas.Hour>06&czas.Hour<18)
            {
                Console.WriteLine("OK");
            }
           
        }
    }
    public class Bateria : IZasilanie
    {
        public int pojemonosc=1000;
        public void zasilaj(int energia)
        {
            if (pojemonosc>energia)
            {
                Console.WriteLine("OK");
                pojemonosc -=100;
            }
            else
            {
                Console.WriteLine("Brak zasilannia");
            }
            
        }
    }
}
