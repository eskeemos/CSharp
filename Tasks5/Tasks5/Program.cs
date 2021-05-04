using System;

namespace Tasks5
{
    class Program
    {
        static double metoda5_1(double fahr) // 5.1
        {
            return (fahr - 32) / 1.8;
        }
        static int[] metoda5_4a(int[] tab, int m) // 5.4
        {
            int[] t1 = new int[tab.Length];
            for (int i = 0; i < tab.Length; i++)
            {
                t1[i] = tab[i] * m;
            }
            return t1;
        }
        static void metoda5_4b(int[] tab, int m) // 5.4
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] *= m;
            }
        }
        static void metoda5_4b(string[] tab, int m) // 5.6
        {
            string helpVar;
            for (int i = 0; i < tab.Length; i++)
            {
                helpVar = tab[i];
                for(int j = 1;j < m; j++)
                {
                    tab[i] += helpVar;
                }
            }
        }
        static void metoda5_7(int x, int n) // 5.7
        {
            int W = 0;
            for (int i = 1; i <= n; i++)
            {
                W += x + i;
            }
            Console.WriteLine("W = {0}", W);
        }
        static int Oblicz(int n) // 5.10
        {
            if (n <= 1) return (1);
            else return (n + Oblicz(n - 1));
        }
        static void Main(string[] args)
        {
            // ZADANIA http://c-sharp.ue.katowice.pl/ksiazka/c_sharp_wer2_0.pdf strona 148
            /*
            // Zadanie 5.1 ----------------------------------------------------------
            Console.WriteLine("Celsjusz : {0:.##} z (Fahrenheit(59))",metoda5_1(59));
            // Zadanie 5.2 ----------------------------------------------------------
            bool metoda5_2(double a, double b, double x)
            {
                return (x > a && x < b);
            }
            if (metoda5_2(1, 9, 5) == true) Console.WriteLine("Liczba {2} należy do przedziału ({0},{1})",1,9,5);
            else Console.WriteLine("Liczba {2} nie należy do przedziału ({0},{1})", 1, 9, 5);
            // Zadanie 5.3 ----------------------------------------------------------
            void Przesun(int[,] point,int[,] wek)
            {
                for (int i = 0; i < 2; i++) point[0, i] += wek[0, i];
                
            }
            int[,] A   = new int[1,2] { { 2, 1 } };
            int[,] wek = new int[1,2] { { 5, 3 } };
            Console.WriteLine("A({0},{1})", A[0, 0], A[0, 1]);
            Przesun(A,wek);
            Console.WriteLine("A({0},{1})", A[0, 0], A[0, 1]);
            // Zadanie 5.4 ----------------------------------------------------------
            int[] tab = new int[5] { 1, 4, 6, 8, 2 };
            metoda5_4a(tab, 2);
            metoda5_4b(tab, 2);
            // Zadanie 5.5 ----------------------------------------------------------
            void Rysuj(int a, int b, char sign)
            {
                for(int i = 0;i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Console.Write(sign);
                    }
                    Console.WriteLine();
                }
            }
            Console.Write("Podaj długość: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Podaj szerokosć: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Podaj znak: ");
            char x3 = char.Parse(Console.ReadLine());
            Rysuj(x1, x2, x3);
            Console.WriteLine();
            Rysuj(x2, x1, x3);
            // Zadanie 5.6 ----------------------------------------------------------
            string[] tab = new string[3] { "ala", "kot", "dom" };
            metoda5_4b(tab, 5);
            foreach (string x in tab) Console.WriteLine(x);
            // Zadanie 5.7 ----------------------------------------------------------
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            metoda5_7(x,n);
            // Zadanie 5.8 ----------------------------------------------------------
            void metoda5_8(string x)
            {
                int suma = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    suma += int.Parse(x.Substring(i,1));
                }
                Console.WriteLine("Suma cyfr z {0} to {1}", x, suma);
            }
            Console.Write("x = ");
            string x = Console.ReadLine();
            metoda5_8(x);
            // Zadanie 5.9 ----------------------------------------------------------
            void ciagI(int n)
            {
                int a = 0, b = 1;
                for (int i = 0; i < n; i++)
                {
                    b += a;
                    a = b - a;
                }
                Console.WriteLine("Wynik to : {0}", a);
            }
            ciagI(int.Parse(Console.ReadLine()));
            int ciagR(int n)
            {
                if (n < 2) return (n);
                else return ciagR(n - 1) + ciagR(n - 2);
            }
            Console.Write("Ciag rekurecyjnie : {0}", ciagR(int.Parse(Console.ReadLine())));
            // Zadanie 5.10 ----------------------------------------------------------
            Console.WriteLine(Oblicz(5));
            */
        }
    }
}
