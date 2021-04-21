using System;
using System.Linq;

namespace CSharpLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // HOME
            Console.WriteLine("Hello World!");
            */
            /*
            // VARIABLES
            int a1 = 5;
            Console.WriteLine("int : " + a1);
            double a2 = 2.2;
            Console.WriteLine("double : " + a2);
            char a3 = 'K';
            Console.WriteLine("char : " + a3);
            string a4 = "Ala ma kota";
            Console.WriteLine("string : " + a4);
            bool a5 = true;
            Console.WriteLine("bool : " + a5);
            const int a6 = 10;
            Console.WriteLine("const int : " + a6);
            */
            /*
            // DATA TYPES
            float a1 = 5e5F;
            Console.WriteLine(a1);
            double a2 = 5e5D;
            Console.WriteLine(a2);
            */
            /*
            // TYPE CASTING
            int a1 = 5;
            double a2 = a1;
            Console.WriteLine(a2);
            double a3 = 6.50;
            int a4 = (int) a3;
            Console.WriteLine(a3);
            Console.WriteLine(a4);
            bool a5 = true;
            Console.WriteLine(Convert.ToString(a1));
            Console.WriteLine(Convert.ToInt32(a3));
            Console.WriteLine(Convert.ToDouble(a1));
            */
            /*
            // USER INPUT
            Console.Write("Enter username : ");
            string username = Console.ReadLine();
            Console.WriteLine("Hello " + username);
            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have " + age);
            */
            /*
            // OPERATORS
            int addition = 100 + 20;
            int substract = 100 - 20;
            int divison = 100 / 20;
            int multiplication = 100 * 20;
            int modulus = 100 % 20;
            int increment = modulus++;
            int decrement = modulus--;
            Console.WriteLine(addition + " " + substract + " " + divison + " " + multiplication + " " + modulus + " " + increment + " " + decrement);
            */
            /*
            // MATH
            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine(Math.Sqrt(16));
            Console.WriteLine(Math.Abs(-10));
            Console.WriteLine(Math.Round(5.10));
            */
            /*
            // STRINGS
            string txt = "Hello World!";
            Console.WriteLine(txt.Length);
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());
            Console.WriteLine(string.Concat(txt,txt));
            string txt2 = $"First : {txt} + {txt}";
            Console.WriteLine(txt2);
            Console.WriteLine(txt2[0]);
            Console.WriteLine(txt2.IndexOf(":"));
            Console.WriteLine(txt2.Substring(6));
            */
            /*
            // Booleans
            Console.WriteLine(5 > 6);
            */
            /*
            // IF ELSE
            int a1 = 11;
            if(a1 < 10)
            {
                Console.WriteLine(" < 10");
            }
            else if(a1 < 20)
            {
                Console.WriteLine(" < 20");
            }
            else
            {
                Console.WriteLine(" < 30");
            }
            Console.WriteLine((a1 < 15) ? "tak" : "nie");
            */

            /*
            // SWITCH
            int a = 5;
            switch(a)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 5:
                    Console.WriteLine("5");
                    break;
                default:
                    Console.WriteLine("Correct case is missing!");
                    break;
            }
            */
            /*
            // WHILE LOOP
            int i;
            i = 0;
            while(i < 5)
            {
                Console.WriteLine(i + 1);
                i++;
            }
            i = 0;
            do
            {
                Console.WriteLine(i + 1);
                i++;
            } while (i < 5);
            */

            /*
            // FOR LOOP
            for(int i = 0;i < 5; i++)
            {
                Console.WriteLine(i + 1);
            }
            string[] cars = { "audi", "bmw", "mercedes"};
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }
            */
            /*
            // FOR LOOP
            for(int i = 0;i<10;i++)
            {
                if(i == 5)
                {
                    continue;
                }
                if(i == 8)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            */
            /*
            // ARRAYS - using System.Linq
            string[] cars = { "Volvo", "BMW", "Ford" };
            int[] nums = { 10, 15, 3, 19 };
            Console.WriteLine(cars[0]);
            cars[0] = "Mercedes";
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars.Length);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
            Array.Sort(cars);
            Console.WriteLine(nums.Max());
            Console.WriteLine(nums.Min());
            Console.WriteLine(nums.Sum());
            int[] tab1 = new int[3];
            int[] tab2 = new int[3] { 1, 2, 3 };
            int[] tab3 = new int[] { 1, 2, 3 };
            int[] tab4 = { 1, 2, 3 };
            */
            // END OF TOTURIAL https://www.w3schools.com/cs/ //


















        }
    }
}
