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
            */
            // Zadanie 4.3 ----------------------------------------------------------
            Console.Write("Podaj liczbe elementów : ");
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            for(int i = 0;i < n; i++)
            {
                Console.Write("tab[{0}] = ",i);
                tab[i] = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
