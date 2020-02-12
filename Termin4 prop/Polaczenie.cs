using System;
using System.Collections.Generic;
using System.Text;

namespace Termin4_prop
{
public class Polaczenie
    {
        public Polaczenie(int numer, DateTime data, TimeSpan czas)
        {
            this.numer = numer;
            this.data = data;
            this.czas = czas;
        }

        public int numer { get; set; }
        public DateTime data { get; set; }
        public TimeSpan czas { get; set; }

        List<Polaczenie> polaczenies = new List<Polaczenie>();
        

    }
}
