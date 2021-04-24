using System;

namespace Tasks1
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://pdf.helion.pl/cshzap/cshzap.pdf
// Zadanie 2.1 / 18
            /*
            int a, b, c;
            Console.WriteLine("Program sprawdza, czy wszystkie liczby a, b, c to trójka pitagorejska.");
            Console.WriteLine("Podaj a.");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b.");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c.");
            c = int.Parse(Console.ReadLine());

            if(((a * a) + (b * b) == (c * c)) || 
               ((b * b) + (c * c) == (a * a)) ||
               ((c * c) + (a * a) == (b * b)))
            {
                Console.WriteLine("Liczby a = {0}, b = {1}, c = {2} są trójką pitagorejską.",a,b,c);
            }
            else
            {
                Console.WriteLine("Liczby a = {0}, b = {1}, c = {2} nie są trójką pitagorejską.",a,b,c);
            }
            */
// Zadanie 2.2 / 20
            /*
            static double F1(string a)
            {
                if (a.Contains("/"))
                {
                    string[] tab = a.Split("/");
                    return Math.Round(F1(tab[0]) / F1(tab[1]),2);
                }
                else
                {
                    return double.Parse(a.Replace('.',','));
                }
            }
            double a, b, c, delta,x1,x2;
            Console.WriteLine("Program oblicza pierwiastki równania ax^2+bx+c = 0.");
            Console.WriteLine("Podaj a.");
            a = F1(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Niedozwolona wartość współczynnika a. Naciśnij klawisz ENTER.");
            }
            else
            {
                Console.WriteLine("Podaj b.");
                b = F1(Console.ReadLine());
                Console.WriteLine("Podaj c.");
                c = F1(Console.ReadLine());

                delta = (b * b) - (4 * a * c);

                if (delta > 0)
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Dla a = {0}, b = {1}, c = {2} trójmian ma dwa pierwiastki: {3:.##}, x2 = {4:.##}", a, b, c, x1, x2);
                }
                else if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("Dla a = {0}, b = {1}, c = {2} trójmian ma jeden pierwiastek podwójny: x1 = {3:.##}", a, b, c, x1);
                }
                else
                {
                    Console.WriteLine("Dla a = {0}, b = {1}, c = {2} brak pierwiastków rzeczywistych", a, b, c);
                }
            }
            */
// Zadanie 2.3 / 22
            /*
            static double F1(string a)
            {
                if (a.Contains("/"))
                {
                    string[] tab = a.Split("/");
                    return Math.Round(F1(tab[0]) / F1(tab[1]), 2);
                }
                else
                {
                    return double.Parse(a.Replace('.', ','));
                }
            }
            double a, b, c, delta, x1, x2;
            int amountOfElements;
            Console.WriteLine("Program oblicza pierwiastki równania ax^2+bx+c = 0.");
            Console.WriteLine("Podaj a.");
            a = F1(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Niedozwolona wartość współczynnika a. Naciśnij klawisz ENTER.");
            }
            else
            {
                Console.WriteLine("Podaj b.");
                b = F1(Console.ReadLine());
                Console.WriteLine("Podaj c.");
                c = F1(Console.ReadLine());

                delta = (b * b) - (4 * a * c);

                
                if(delta > 0) amountOfElements = 2;
                else if (delta == 0) amountOfElements = 1;
                else amountOfElements = 0;

                switch (amountOfElements)
                {
                    case 0:
                        Console.WriteLine("Dla a = {0}, b = {1}, c = {2} brak pierwiastków rzeczywistych.", a, b, c);
                        break;
                    case 1:
                        x1 = -b / (2 * a);
                        Console.WriteLine("Dla a = {0}, b = {1}, c = {2} trójmian ma jeden pierwiastek podwójny: x1 = {3:.##}.", a, b, c, x1);
                        break;
                    case 2:
                        x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                        x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                        Console.WriteLine("Dla a = {0}, b = {1}, c = {2} trójmian ma dwa pierwiastki: {3:.##}, x2 = {4:.##}.", a, b, c, x1, x2);
                        break;
                }
            */
// Zadanie 2.4 / 24
            /*
            static double F1(string a)
            {
                if (a.Contains("/"))
                {
                    string[] tab = a.Split("/");
                    return Math.Round(F1(tab[0]) / F1(tab[1]), 2);
                }
                else
                {
                    return double.Parse(a.Replace('.', ','));
                }
            }
            double a, b, c, x;
            Console.WriteLine("Program oblicza warto x z równania liniowego ax+b = 0.");
            Console.WriteLine("Podaj a.");
            a = F1(Console.ReadLine());
            if(a == 0)
            {

            }
            else
            {
                Console.WriteLine("Podaj b.");
                b = F1(Console.ReadLine());
                Console.WriteLine("Podaj c.");
                c = F1(Console.ReadLine());


                x = (c - b) / a;

                Console.WriteLine("Dla a = {0}, b = {1}, c = {2} wartość x = {3}.",a,b,c,x);
            }
            */
// Zadanie 2.5 / 25
            /*
            double drawn, shot;
            Console.WriteLine("Program losuje liczbę od 0 do 9. Zgadnij ją.");

            Random r = new Random();
            drawn = Math.Round(10 * (r.NextDouble()));
            shot = int.Parse(Console.ReadLine());

            if(drawn == shot)
            {
                Console.WriteLine("Gratulacje! Zgadłeś liczbę!");
            }
            else
            {
                Console.WriteLine("Bardzo mi przykro, ale wylosowana liczba to {0}.", drawn);
            }
            */
        }
    }
}
