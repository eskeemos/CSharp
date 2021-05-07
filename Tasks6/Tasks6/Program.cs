using System;

namespace Tasks6
{
    class Prostokat
    {
        double dlugosc,
               szerokosc;
        public Prostokat(double a, double b)
        {
            dlugosc = a;
            szerokosc = b;
        }
        public static void najwiekszy(Prostokat[] tab)
        {
            double najwiekszy = 0; ;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i].powierzchnia() > najwiekszy) najwiekszy = tab[i].powierzchnia();
            }
            Console.WriteLine("Największa powierzchnia : {0}", najwiekszy);
        }
        private double powierzchnia()
        {
            return dlugosc * szerokosc;
        }
        private double obwod()
        {
            return 2 * (dlugosc + szerokosc);
        }
        public void Prezentuj()
        {
            Console.Write("Powierzchnia : {0}\nObwód : {1}\n", powierzchnia(), obwod());
        }
    }
    class Energia
    {
        double initConsumption = .0;
        public double CurrConsumption { get; set; }
        public Energia(double initC, double currC)
        {
            initConsumption = initC;
            CurrConsumption = currC;
        }
        public void GetData()
        {
            Console.WriteLine("Stan początkowy : {0}\nStan Bieżący : {1}", initConsumption, CurrConsumption);
        }
        public void EnergyUsed()
        {
            double EConsumed = CurrConsumption - initConsumption;
            Console.WriteLine("Energy consumed : {0}\n", EConsumed);
        }
    }
    class Punkt
    {
        public int x;
        public int y;
        public Punkt(params int[] pkt)
        {
            x = pkt[0];
            y = pkt[1];
        }
        public void Przesun(params int[] pkt)
        {
            x += pkt[0];
            y += pkt[1];
        }
        public void Wyświetl()
        {
            Console.WriteLine("Aktulne współrzędne : P({0},{1})", x, y);
        }
        public static void NaProstej(Punkt[] pkts)
        {
            int Cy = pkts[0].y - pkts[0].x;
            int prawda = 1;
            for (int i = 0; i < pkts.Length; i++)
            {
                if (pkts[i].x + Cy != pkts[i].y)
                {
                    Console.WriteLine("Punkty nie są współliniowe.");
                    prawda = 0; break;
                }
            }
            if (prawda == 1) Console.WriteLine("Punkty są współliniowe.");
        }
    }
    class Odcinek
    {
        int x, y;
        double wynik;
        public Odcinek(Punkt p1, Punkt p2)
        {
            x = p1.x - p2.x;
            y = p1.y - p2.y;
        }
        public void Długość()
        {
            wynik = Math.Sqrt(Math.Pow(y, 2) + Math.Pow(x, 2));
            Console.WriteLine("Dłogość odcinka : {0:.##}", wynik);
        }
    }
    class Prostopadloscian
    {
        double dlugosc, szerokosc, wysokosc;
        public Prostopadloscian(double a, double b, double c)
        {
            dlugosc = a;
            szerokosc = b;
            wysokosc = c;
        }
        public double Objetosc()
        {
            return dlugosc * szerokosc * wysokosc;
        }
        public static void Porowannanie2Obj(double obj1, double obj2)
        {
            string helpVar;
            if (obj1 > obj2) helpVar = "pierwszym";
            else helpVar = "drugim";
            Console.WriteLine("Prostopadłoscian podany w {0} argumencie ma większą objętość.", helpVar);
        }
    }
    struct Prostokat_
    {
        double dlugosc,
               szerokosc;
        public Prostokat_(double a, double b)
        {
            dlugosc = a;
            szerokosc = b;
        }
        private double powierzchnia()
        {
            return dlugosc * szerokosc;
        }
        private double obwod()
        {
            return 2 * (dlugosc + szerokosc);
        }
        public void Prezentuj()
        {
            Console.Write("Powierzchnia : {0}\nObwód : {1}\n", powierzchnia(), obwod());
        }
    }
    struct KandydatNaStudia
    {
        public string nazwisko;
        public double punktyMatematyka,
            punktyInformatyka,
            punktyJezykObcy;
        public KandydatNaStudia(string a, int b, int c, int d)
        {
            nazwisko = a;
            punktyMatematyka = b;
            punktyInformatyka = c;
            punktyJezykObcy = d;
        }
        public double SumaPunktow()
        {
            return punktyMatematyka * .6 + punktyInformatyka * .5 + punktyJezykObcy * .2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // ZADANIA http://c-sharp.ue.katowice.pl/ksiazka/c_sharp_wer2_0.pdf strona 181
            /*
            // Zadanie 6.1 ----------------------------------------------------------
            Prostokat p = new Prostokat(4, 6);
            p.Prezentuj();
            // Zadanie 6.2 ----------------------------------------------------------
            Prostokat[] tab = {new Prostokat(2,8), new Prostokat(4,6), new Prostokat(5,5)};
            foreach(Prostokat x in tab) x.Prezentuj();
            // Zadanie 6.3 ----------------------------------------------------------
            Prostokat[] tab = {new Prostokat(2,8), new Prostokat(4,6), new Prostokat(5,5)};
            Prostokat.najwiekszy(tab);
            // Zadanie 6.4 ----------------------------------------------------------
            Energia e1 = new Energia(200.50,550.90);
            e1.GetData();
            e1.EnergyUsed();
            // Zadanie 6.5 ----------------------------------------------------------
            Punkt p1 = new Punkt(5,5);
            p1.Przesun(2, 3);
            p1.Wyświetl();
            // Zadanie 6.6 ----------------------------------------------------------
            Punkt[] punkty = { new Punkt(2,4),new Punkt(5,7),new Punkt(4,6)};
            Punkt.NaProstej(punkty);
            // Zadanie 6.7 ----------------------------------------------------------
            Odcinek odc1 = new Odcinek(new Punkt(2,2), new Punkt(3,3));
            odc1.Długość();
            // Zadanie 6.8 ----------------------------------------------------------
            Prostopadloscian p1 = new Prostopadloscian(10, 20, 30);
            Console.WriteLine("Objętosć p1 to : {0}", p1.Objetosc());
            Prostopadloscian.Porowannanie2Obj(new Prostopadloscian(5, 10, 5).Objetosc(), new Prostopadloscian(6, 6, 6).Objetosc());
            // Zadanie 6.9 ----------------------------------------------------------
            Prostokat_[] tab = { new Prostokat_(2, 8), new Prostokat_(4, 6), new Prostokat_(5, 5) };
            foreach (Prostokat_ x in tab) x.Prezentuj();
            // Zadanie 6.10 ---------------------------------------------------------
            KandydatNaStudia[] kandydat = { new KandydatNaStudia("Baranowski",55,89,100),
                                            new KandydatNaStudia("Karolek",40,90,56),
                                            new KandydatNaStudia("Wrobel",77,23,45)};
            for(int i = 0;i < kandydat.Length;i++)
            {
                Console.WriteLine("Kandydat {0} uzyskał wynik : {1:.#}", kandydat[i].nazwisko, kandydat[i].SumaPunktow());
            }
            */
        }
    }
}
