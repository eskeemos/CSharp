using System;
using System.Collections;
using System.Linq;

namespace Tasks3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ZADANIA http://c-sharp.ue.katowice.pl/ksiazka/c_sharp_wer2_0.pdf strona 54
            // Zadanie 3.1 ----------------------------------------------------------
            /*
            Console.Write("Podaj rok : ");
            int rok = int.Parse(Console.ReadLine());
            if(((rok % 4) == 0) && (((rok % 100) != 0) || ((rok % 400) == 0)))
            {
                Console.WriteLine("Rok jest przestępny");
            }
            else
            {
                Console.WriteLine("Rok nie jest przestępny");
            }
            */
            // Zadanie 3.2 ----------------------------------------------------------
            /*
            Console.Write("Podaj pierwszą liczbę : ");
            int var1 = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę : ");
            int var2 = int.Parse(Console.ReadLine());
            if((var1 % var2) == 0)
            {
                Console.WriteLine("Druga liczba jest dzielnikiem pierwszej.");
            }
            else
            {
                Console.WriteLine("Druga liczba nie jest dzielnikiem pierwszej.");
            }
            // Zadanie 3.3 ----------------------------------------------------------
            int[] nums = new int[3];
            for(int i = 1;i < 4; i++)
            {
                Console.WriteLine("Podaj liczbę nr{0} : ", i);
                nums[i-1] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Największa wartośc spośród wprowadzonych to " + nums.Max());
            // Zadanie 3.4 ----------------------------------------------------------
            char sign;
            double var1, var2, wynik;
            Console.Write("Podaj operator logiczny(+|-|*|/) : ");
            sign = char.Parse(Console.ReadLine());
            Console.Write("Podaj pierwszą liczbę : ");
            var1 = double.Parse(Console.ReadLine());
            Console.Write("Podaj pierwszą liczbę : ");
            var2 = double.Parse(Console.ReadLine());
            switch (sign)
            {
                case '+':
                    wynik = var1 + var2;
                    Console.WriteLine("Wynik to : {0}", wynik);
                    break;
                case '-':
                    wynik = var1 - var2;
                    Console.WriteLine("Wynik to : {0}", wynik);
                    break;
                case '*':
                    wynik = var1 * var2;
                    Console.WriteLine("Wynik to : {0}", wynik);
                    break;
                case '/':
                    wynik = var1 / var2;
                    Console.WriteLine("Wynik to : {0}", wynik);
                    break;
            }
            // Zadanie 3.5 ----------------------------------------------------------
            double a, b, c,delta;
            Console.Write("Podaj a :");
            a = double.Parse(Console.ReadLine());
            Console.Write("Podaj b :");
            b = double.Parse(Console.ReadLine());
            Console.Write("Podaj c :");
            c = double.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if(delta > 0)
            {
                Console.WriteLine("Dwa rozwiązania");
            }
            else if(delta == 0)
            {
                Console.WriteLine("Jedno rozwiązanie");
            }
            else
            {
                Console.WriteLine("Brak rozwiązań");
            }
            // Zadanie 3.6 ----------------------------------------------------------
            Console.Write("Podaj wagę w kilogramch : ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Podaj wzrost w metrach : ");
            double height = double.Parse(Console.ReadLine());
            double BMI = weight / (height * height);
            if(BMI < 18.5)
            {
                Console.WriteLine("niedowaga");
            }
            else if(BMI < 24.99)
            {
                Console.WriteLine("wartość prawidłowa");
            }
            else
            {
                Console.WriteLine("nadwaga");
            }
            // Zadanie 3.7 ----------------------------------------------------------
            Console.WriteLine("Wpisz nr dnia tygodnia");
            string numer = Console.ReadLine();
            switch (numer)
            {
                case "1":
                    Console.WriteLine("Poniedziałek");
                    break;
                case "2":
                    Console.WriteLine("Wtorek");
                    break;
                case "3":
                    Console.WriteLine("Środa");
                    break;
                case "4":
                    Console.WriteLine("Czwartek");
                    break;
                case "5":
                    Console.WriteLine("Piątek");
                    break;
                case "6":
                    Console.WriteLine("Sobota");
                    break;
                case "7":
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego dnia tygodnia");
                    break;
            }
            // Zadanie 3.8 ----------------------------------------------------------
            Console.Write("Podak średnią ocen : ");
            double Mavg = double.Parse(Console.ReadLine());
            if((Mavg >= 2.00) && (Mavg < 3.99))
            {
                Console.WriteLine("Stypendium : 0.00 zł");
            }
            else if(Mavg <= 4.79)
            {
                Console.WriteLine("Stypendium : 350.00 zł");
            }
            else if(Mavg <= 5.00)
            {
                Console.WriteLine("Stypendium : 550.00 zł");
            }
            */
            // Zadanie 3.9 ----------------------------------------------------------
        }
    }
}
