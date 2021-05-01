using System;

namespace Tasks4
{
    class Program
    {
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
            */
        }
    }
}
