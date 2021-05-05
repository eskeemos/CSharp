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
            for(int i = 0;i < tab.Length; i++)
            {
                if(tab[i].powierzchnia() > najwiekszy) najwiekszy = tab[i].powierzchnia();
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
            */
        }
    }
}
