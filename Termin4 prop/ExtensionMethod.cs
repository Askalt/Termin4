using System;
using System.Collections.Generic;
using System.Text;

namespace Termin4_prop
{
    public static class ExtensionMethod
    {
        public static string Zwracanie_znaku(this string napis,int liczba_znaku)
        {
            int ilosc = 0;
            if (napis.Length<liczba_znaku)
            {
                return napis;
            }
            else if (napis.Length>liczba_znaku)
            {
                foreach (var item in napis)
                {
                    if (ilosc==liczba_znaku)
                    {
                        Console.WriteLine("...");
                        break;
                    }
                    Console.WriteLine(item);
                    ilosc++;
                }
            }
            return napis;

           
        }

    }
}
