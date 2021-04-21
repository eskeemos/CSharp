using System;

namespace CSharpMethods
{
    class Program
    {
        static void Method1()
        {
            Console.WriteLine("Hello World!");
        }
        static void Method2(string fname)
        {
            Console.WriteLine("Ms/Mrs {0}", fname);
        }
        static void Method3(string country = "Poland")
        {
            Console.WriteLine("Country : {0}", country);
        }
        static void Method4(string fname,int age)
        {
            Console.WriteLine("{0} is {1} years old",fname, age);
        }
        static int Method5(int a, int b)
        {
            return (a + b) * 10;
        }
        static void Method6(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is {0}", child1);
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            // Methods
            Method1();
            // Method Parameters
            Method2("Jackie");
            Method3("Norway");
            Method3();
            Method3("Russia");
            Method4("Pavlo", 17);
            Console.WriteLine(Method5(4, 9));
            Method6(child3: "Jonatan", child1: "Gari", child2: "Alicja");
            // Method Overloading
            Console.WriteLine("Int : " + Sum(5,7));
            Console.WriteLine("Double : " + Sum(5.7,7.1));
            






        }
    }
}
