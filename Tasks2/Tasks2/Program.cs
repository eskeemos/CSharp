using System;

namespace Tasks2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ZADANIA http://c-sharp.ue.katowice.pl/ksiazka/c_sharp_wer2_0.pdf strona 54
            // Zad 2.1
            /*
            double celc, fahr;
            Console.Write("Podaj temperaturę w stopniach Celsjusza : ");
            celc = double.Parse(Console.ReadLine());
            fahr = 32 + (9D / 5) * celc;
            Console.WriteLine("Temperatura w Fahrenheita to : {0:.#}", fahr);
            // Zad 2.2
            double a, b, c, delta;
            Console.Write("Podaj a : ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Podaj b : ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Podaj c : ");
            c = double.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;
            Console.WriteLine("Delta to {0:.##}", delta);
            // Zad 2.3
            double height, weight, BMI;
            Console.Write("Podaj wage w kilogramach : ");
            weight = double.Parse(Console.ReadLine());
            Console.Write("Podaj wzrost w metrach: ");
            height = double.Parse(Console.ReadLine());
            BMI = weight / (height * height);
            Console.WriteLine("Twoje BMI to {0:.##}", BMI);
            // Zad 2.4
            int x = 100;
            Console.WriteLine(++x * 2);
            // Zad 2.5
            int x = 2, y = 3;
            x *= y * 2;
            Console.WriteLine(x);
            // Zad 2.6
            int x, y = 4;
            x = (y -= 2); // x = 2, y = 2
            x = y++; // x = 2, y = 3
            x = y--; // x = 3, y = 2
            Console.WriteLine(x);
            // Zad 2.7
            int x, y = 5; // x, y = 5
            x = ++y * 2;  // x = 12, y = 5
            x = y++;      // x = 5, y = 7
            Console.WriteLine(++y); // x = 5, y = 8
            // Zad 2.8
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1); // x = false ,y = 1, z = 2
            Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
            // Zad 2.9 a
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 && y++ == 4 && z-- > 0); // wynik = False, x = 2, y = 4, z = 2
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            // Zad 2.9 b
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 && z-- > 0); // wynik = False, x = 2, y = 5, z = 2
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            // Zad 2.9 c
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 & z-- > 0); // wynik = False, x = 2, y = 5, z = 1
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            // Zad 2.9 d
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 || y++ > 2 || ++z > 0); // wynik = True, x = 2, y = 3, z = 4
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            // Zad 2.9 e
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 || ++z > 0); // wynik = True, x = 1, y = 4, z = 4
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            // Zad 2.9 f
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 | ++z > 0); // wynik = True, x = 1, y = 4, z = 5
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            // Zad 2.10
            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = (double) osoby / powierzchnia;
            Console.WriteLine(gestoscZaludnienia);
            */
        }
    }
}
