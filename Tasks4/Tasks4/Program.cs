using System;
using System.Collections;
using System.Linq;

namespace Tasks4
{
    class Program
    {
        private const char V = ' ';

        static void Main(string[] args)
        {
            // ZADANIA http://c-sharp.ue.katowice.pl/ksiazka/c_sharp_wer2_0.pdf strona 121
            // Zadanie 4.1 ----------------------------------------------------------
            /*
            Console.Write("Podaj liczbę elementów : ");
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            for(int i = 0;i < n; i++) tab[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Elementy tablicy : ");
            foreach (int x in tab) Console.Write(x + " ");
            // Zadanie 4.2 ----------------------------------------------------------
            int[] tab1 = { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10 };
            int[] tab2 = new int[10];
            int h1 = 0;
            for(int i = 0;i < tab1.Length; i++)
            {
                if (tab1[i] > 0)
                {
                    Array.Copy(tab1,i,tab2,h1++,1);
                }
            }
            foreach (int x in tab2) Console.Write(x + " ");
            // Zadanie 4.3 ----------------------------------------------------------
            Console.Write("Podaj liczbe elementów : ");
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            for(int i = 0;i < n; i++)
            {
                Console.Write("tab[{0}] = ",i);
                tab[i] = int.Parse(Console.ReadLine());
            }
            int max = tab[0],min = tab[0],pos = 0;
            double avg = 0 ;
            string idxMax = "", idxMin = "";
            for(int i = 0;i < n; i++)
            {
                if(tab[i] > max)
                {
                    max = tab[i];
                    idxMax = Convert.ToString(Array.IndexOf(tab, max) + 1);
                }
                else if(tab[i] == max) idxMax += " " + Convert.ToString(Array.IndexOf(tab, max, i) + 1);
                if (tab[i] < min)
                {
                    min = tab[i];
                    idxMin = Convert.ToString(Array.IndexOf(tab, min) + 1);
                }
                else if (tab[i] == min) idxMin += " " + Convert.ToString(Array.IndexOf(tab, min, i) + 1);
                avg += tab[i];
                if (tab[i] > 0) pos++;
            }avg /= n;
            Console.WriteLine("Największy element tablicy : {0}, na pozycji/pozycjach : {1}", max, idxMax);
            Console.WriteLine("Najmniejszy element tablicy : {0},  na pozycji/pozycjach : {1}", min, idxMin);
            Console.WriteLine("Srednia elementów tablicy : {0}", avg); 
            Console.WriteLine("Liczba dodatnich elementów tablicy : {0}", pos); 
            // Zadanie 4.4 ----------------------------------------------------------
            int czyPierwsza(int a,ref int b)
            {
                for(int i = 2;i < Math.Sqrt(a); i++)
                {
                    if (a % i == 0) return 0;          
                }
                b++;return 0;
            }
            int pierwsza = 0;
            Random rand = new Random();
            int[] tab = new int[100];
            for(int i = 0;i < 100; i++)
            {
                tab[i] = rand.Next();
                czyPierwsza(tab[i], ref pierwsza);
            }
            Console.WriteLine("Ilośc liczb pierwszych : {0}", pierwsza);
            // Zadanie 4.5 ----------------------------------------------------------   
            const int n = 5;
            int[] tab1 = new int[n] { 1, 2, 3, 4, 5 };
            int[] tab2 = new int[n];
            Array.Copy(tab1, 4, tab2, 0, 1);
            Array.Copy(tab1,0,tab2,1,4);
            foreach (int x in tab2) Console.WriteLine(x);
            // Zadanie 4.6 ---------------------------------------------------------- 
            int[,] tab = new int[5, 5] {
                { 1, 0, 0, 0, 1 },
                { 0, 1, 0, 1, 0 },
                { 0, 0, 1, 0, 0 },
                { 0, 1, 0, 1, 0 },
                { 1, 0, 0, 0, 1 }};
            int suma = 0;
            for(int i = 0;i < 5; i++)
            {
                for(int j = 0;j < 5; j++)
                {
                    if ((i == j)||(i == 4 - j)) { suma += tab[i,j]; }
                    Console.Write(tab[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Suma przekątnych : {0}",suma);
            // Zadanie 4.7 ---------------------------------------------------------- 
            int[,] tab1 = new int[2,3] { { 1, 2, 3 }, { 2, 4, 5 } };
            int[,] tab2 = new int[2,3] { { 6, 2, 1 }, { 4, 2, 3 } };
            int[,] tab3 = new int[2, 3];
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    tab3[i, j] = tab2[i, j] + tab1[i, j];
                    Console.Write(tab3[i, j] + " ");
                }
                Console.WriteLine();
            }
            // Zadanie 4.8 ---------------------------------------------------------- 
            string[,] dniTygodnia = new string[7, 3] {
                { "Poniedziałek","Monday", "Montag"},
                { "Wtorek","Tuesday", "Dienstag"},
                { "Środa","Wednsday", "Mittwoch"},
                { "Czwartek","Thursday", "Donnerstag"},
                { "Piątek","Friday", "Freitag"},
                { "Sobota","Saturday", "Samstag"},
                { "Niedziela","Sunday", "Sonntag"}};
            for(int i = 0;i < 7; i++)
            {
                Console.Write(dniTygodnia[i, 0]);
                for (int j = 1;j < 3; j++)
                {
                    Console.Write(" " + dniTygodnia[i, j]); 
                }
                Console.WriteLine();
            }
            // Zadanie 4.9 ---------------------------------------------------------- 
            string txt = Console.ReadLine();
            string[] tab = txt.Split(" ");
            Console.WriteLine(tab.Length);
            // Zadanie 4.10 ---------------------------------------------------------- 
            Console.Write("Podaj date w formacie(23-11-2009) : ");
            int month = int.Parse(Console.ReadLine().Substring(3,2));
            switch (month)
            {
                case 1:
                    Console.WriteLine("Styczeń");
                    break;
                case 2:
                    Console.WriteLine("Luty");
                    break;
                case 3:
                    Console.WriteLine("Marzec");
                    break;
                case 4:
                    Console.WriteLine("Kwiecień");
                    break;
                case 5:
                    Console.WriteLine("Maj");
                    break;
                case 6:
                    Console.WriteLine("Czerwiec");
                    break;
                case 7:
                    Console.WriteLine("Lipiec");
                    break;
                case 8:
                    Console.WriteLine("Sierpień");
                    break;
                case 9:
                    Console.WriteLine("Wrzesień");
                    break;
                case 10:
                    Console.WriteLine("Październik");
                    break;
                case 11:
                    Console.WriteLine("Listopad");
                    break;
                case 12:
                    Console.WriteLine("Grudzień");
                    break;
            }
            // Zadanie 4.11 ---------------------------------------------------------- 
            string txt = Console.ReadLine().ToLower();
            var tab = txt.ToCharArray().Distinct().Where((x) => x != ' ').ToArray();

            for(int i = 0;i < tab.Length; i++)
            {
                int amount = txt.ToCharArray().Count((x) => x == txt[i]);
                Console.WriteLine("'{0}' - {1}", tab[i], amount);
            }
            // Zadanie 4.12 ---------------------------------------------------------- 
            // fragment powieści A. A. Milne, "Kubuś Puchatek"
            string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
             "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
             "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
             "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
             "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";

            Console.WriteLine("Zawartość : {0}", tekst);
            var rowsCount = tekst.Split("\n").Count();
            Console.WriteLine("Liczba wierszy : {0}", rowsCount);
            string[] rows = tekst.Split("\n");
            int amount;
            for(int i = 0;i < rowsCount; i++)
            {
                amount = rows[i].Count();
                Console.WriteLine("Ilość znaków w lini {0} : {1}", i + 1,amount);
            }
            // Zadanie 4.13 ---------------------------------------------------------- 
            string txt = "Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się idzie - odpowiedział Puchatek";
            var tab = txt.Split(' ',',','.').Where((x) => (x != "") && (x != "-") ).ToArray();
            int suma;
            for(int i = 0;i < tab.Length; i++)
            {
                suma = tab.Count((x) => x == tab[i]);
                Console.WriteLine("{0} = {1} razy",tab[i],suma);
            }
            // Zadanie 4.14 ----------------------------------------------------------
            string[] tab = new string[5] { "ABC-2009", "ASD-2012", "QWE-2020", "GHJ-2005", "JKL-2001" };
            int year;
            for(int i = 0;i < tab.Length; i++)
            {
                year = DateTime.Now.Year -  int.Parse(tab[i].Split("-")[1]);
                Console.WriteLine("Lata upłynięte od zakupu : {0}",year);
            }
            // Zadanie 4.15 ----------------------------------------------------------
            string zaszyfrowany = String.Empty;
            const string key = "GADERYPOLUKI";
            Console.Write("Podaj tekst do zaszyfrowania : ");
            string txt = Console.ReadLine().ToUpper();
            int idx;
            for(int i = 0;i < txt.Length; i++)
            {
                idx = key.IndexOf(txt[i]);
                if (idx != -1)
                {
                    if(idx % 2 == 0)
                    {
                        zaszyfrowany += key.Substring(idx + 1,1);
                    }
                    else
                    {
                        zaszyfrowany += key.Substring(idx - 1, 1);
                    }
                }
                else
                {
                    zaszyfrowany += txt[i];
                }
            }
            Console.WriteLine("Zaszyfrowany tekst : {0}", zaszyfrowany);
            */
        }
    }
}
