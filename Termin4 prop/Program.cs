using System;
using System.Collections.Generic;
using System.Linq;

namespace Termin4_prop
{
    class Program
    {
        static void Main(string[] args)
        {
            #region z1
            //Krdynant krdynant = new Krdynant();
            //XiY xiY = new XiY();
            //krdynant.UP += xiY.WGore;
            //krdynant.DOWN += xiY.WDol;
            //krdynant.LEFT += xiY.WLewo;
            //krdynant.LEFT += xiY.WLewo;
            //krdynant.LEFT += xiY.WLewo;
            //krdynant.RIGHT += xiY.WPrawo;

            //krdynant.Up();
            //krdynant.Down();
            //krdynant.Left();
            //krdynant.Right();
            #endregion
            #region z2
            //Stworz liste produktow oraz klase produkty 
            //kazdy produkt skladasie z3skladnikuow stworzkalse skladniki wegle tluszcz sol
            //List<Produkty> produkties = new List<Produkty>();
            //List<Skladniki> skladnikis = new List<Skladniki>();
            //skladnikis.Add(new Skladniki(400, 20, 100));
            //skladnikis.Add(new Skladniki(20, 500, 200));
            //skladnikis.Add(new Skladniki(40, 20, 300));
            //produkties.Add(new Produkty(skladnikis));

            //List<Skladniki> skladnikis1 = new List<Skladniki>();
            //skladnikis1.Add(new Skladniki(222, 333, 444));
            //skladnikis1.Add(new Skladniki(222, 333, 555));
            //produkties.Add(new Produkty(skladnikis1));

            //foreach (Produkty item in produkties)
            //{
            //    Console.WriteLine($"Weglowodany:{item.list.Sum(x => x.welowodany)}");
            //    Console.WriteLine($"Tłuszcz:{item.list.Sum(x => x.tluszcz)}");
            //}
            #endregion
            #region z3 EM
            //2G.Stwórz extension method dla typu string.
            //    Metoda powinna przyjmować liczbę znaków i zwracać tekst.
            //    Jeśli tekst jest krótszy niż podana ilość znaków, zwróć cały tekst.
            //    Jeśli tekst jest dłuższy niż podana liczba,
            //skróć go do danej długości a ostatnie 3 znaki zamień na kropki.
            //    Załóż, że użytkownik funkcji nie przyśle liczby mniejszej niż 3.
            string napis = "Konstantynopol";
            napis.Zwracanie_znaku(5);
            #endregion
            #region z4 
            //3G.Stwórz klasę Hex z polem tekstowym Kod, która przechowa informacje o kolorze(np.FFAEAE)
            //    .Stwórz dekonstruktor który zwróci 3 stringi(R, G i B)
            //    w formacie hex(po dwie litery z kodu).Dodaj dekonstruktor,
            //który zwróci 3 liczby całkowite(0 - 255). Skorzystaj z Convert.ToInt(...).
            //Hex hex = new Hex("FFEUEAA");
            //var (r, g, b) = hex;
            //Console.WriteLine($"{r} {g} {b}");


            #endregion
            #region z5
            //4G.Stwórz interfejs IZasilanie z metodą void Zasilaj(int energia).
            //Stwórz dwie klasy implementujące IZasilanie: PanelSloneczny i Bateria.
            //    W klasie PanelSloneczny metoda Zasilanie powinna wypisać "OK" 
            //    jeśli energia jest mniejsza niż 100 i tylko w godzinach 6:00 - 18:00(wczytaj godzinę z systemu)
            //    .Klasa Bateria powinna posiadać pole Pojemność.
            //    Metoda Zasilanie powinna wypisać "Ok", jeśli ma dość pojemności.
            //    Zmniejsz Pojemność po każdym użyciu.Jeśli nie da się zasilić odbiornika, wypisz "Brak zasilania".
            //    Stwórz obiekty obu klasy i wywołaj metodę interfejsu.

            //IZasilanie zasilanie = new PanelSloneczny();
            //zasilanie.zasilaj(1000);
            //IZasilanie zasilanie1 = new Bateria();
            //zasilanie1.zasilaj(2000);
            #endregion
            #region z6
            //    5G.Stwórz klasę Panel.Dodaj do niej 4 eventy: UP, DOWN, LEFT, RIGHT
            //        .Dodaj 4 funkcje, które będą wywoływać konkretne eventy.Stwórz klasę Robot
            //        .Zapisz w niej informację o współrzędnych X i Y.Dodaj do Robot 4 event handlery,
            //które będą zmieniać pozycję robota
            //    (lewo: X-1, prawo: x+1, góra: y+1, dół: y-1) i wypisywać ją do konsoli.
            //    Stwórz oba obiekty i połącz handlery z odpowiednimi eventami.Wywołaj kilka metod z Panelu.
            //Panel panel = new Panel();
            //Robot robot = new Robot();

            //panel.UP += robot.WGore;
            //panel.DOWN += robot.WDol;
            //panel.DOWN += robot.WDol;
            //panel.DOWN += robot.WDol;
            //panel.LEFT += robot.WLewo;
            //panel.RIGHT += robot.WPrawo;
            //panel.RIGHT += robot.WPrawo;
            //panel.RIGHT += robot.WPrawo;

            //panel.Down();
            //panel.Up();
            //panel.Right();
            //panel.Left();

            #endregion

            #region z1f
            //1F.Stwórz klasę Połączenie. Dodaj do niej pola int Numer, DateTime Data i TimeSpan Czas.
            //    Stwórz kolekcję 50 połączeń i wypełnij losowymi danymi z rozsądnych zakresów(przyjmij,
            //        że połączenia mogą się nachodzić w czasie).
            //Posortuj połączenia chronologicznie.Zapisz do innej zmiennej kolekcję posortowaną po długości połączenia.
            //    Zapisz do innej zmiennej wszystkie połaczenia z operatorem X, którego numery z
            //    aczynają się od cyfry '5'.Zlicz ich średni czas trwania w sekundach.
            List<Polaczenie> polaczenies = new List<Polaczenie>();
            
            #endregion
        }
    }
}
