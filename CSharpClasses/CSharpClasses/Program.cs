using System;
using System.IO;

namespace CSharpClasses
{
    // Classes/Objects
    /*
    class Car
    {
        string color = "red";
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
        }
    }
    class Car
    {
        string color = "red";
        static void Main(string[] args)
        {
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cars myObj = new Cars();
            Console.WriteLine(myObj.color);
        }
    }
    */
    // Class Members
    /*
    class Car
    {
        string color = "red";
        int maxSpeed = 200;

        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
        }
    }
    class Car
    {
        string color;
        int maxSpeed;

        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.color = "red";
            myObj.maxSpeed = 200;
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
        }
    }
    class Car 
    {
      string model;
      string color;
      int year;

      static void Main(string[] args)
      {
        Car Ford = new Car();
        Ford.model = "Mustang";
        Ford.color = "red";
        Ford.year = 1969;

        Car Opel = new Car();
        Opel.model = "Astra";
        Opel.color = "white";
        Opel.year = 2005;

        Console.WriteLine(Ford.model);
        Console.WriteLine(Opel.model);
      }
    }
    class Car 
    {
      string color;                 
      int maxSpeed;                 
      public void fullThrottle()    
      {
        Console.WriteLine("The car is going as fast as it can!"); 
      }

      static void Main(string[] args)
      {
        Car myObj = new Car();
        myObj.fullThrottle();  
      }
    }
    class Program
    {
      static void Main(string[] args)
      {
        Car Ford = new Car();
        Ford.model = "Mustang";
        Ford.color = "red";
        Ford.year = 1969;

        Car Opel = new Car();
        Opel.model = "Astra";
        Opel.color = "white";
        Opel.year = 2005;

        Console.WriteLine(Ford.model);
        Console.WriteLine(Opel.model);
      }
    }
    */
    // Constructors
    /*
    class Car
    {
      public string model; 

      public Car()
      {
        model = "Mustang"; 
      }

      static void Main(string[] args)
      {
        Car Ford = new Car();  
        Console.WriteLine(Ford.model);  
      }
    }
    class Car
    {
      public string model;

      public Car(string modelName)
      {
        model = modelName;
      }

      static void Main(string[] args)
      {
        Car Ford = new Car("Mustang");
        Console.WriteLine(Ford.model);
      }
    }
    class Car
    {
      public string model;
      public string color;
      public int year;

      // Create a class constructor with multiple parameters
      public Car(string modelName, string modelColor, int modelYear)
      {
        model = modelName;
        color = modelColor;
        year = modelYear;
      }

      static void Main(string[] args)
      {
        Car Ford = new Car("Mustang", "Red", 1969);
        Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
      }
    }
    */
    // ACCESS MODIFIERS
    /*
    class Car
    {
      private string model = "Mustang";

      static void Main(string[] args)
      {
        Car myObj = new Car();
        Console.WriteLine(myObj.model);
      }
    }
    class Car
    {
      public string model = "Mustang";
    }

    class Program
    {
      static void Main(string[] args)
      {
        Car myObj = new Car();
        Console.WriteLine(myObj.model);
      }
    } 
    */
    // PROPERTIES
    /*
    class Person
    {
      private string name; // field
      public string Name   // property
      {
        get { return name; }
        set { name = value; }
      }
    }

    class Program
    {
      static void Main(string[] args)
      {
        Person myObj = new Person();
        myObj.Name = "Liam";
        Console.WriteLine(myObj.Name);
      }
    }
    class Person
    {
      public string Name  // property
      { get; set; }
    }

    class Program
    {
      static void Main(string[] args)
      {
        Person myObj = new Person();
        myObj.Name = "Liam";
        Console.WriteLine(myObj.Name);
      }
    }
    */
    // INHERITANCE (!sealed)
    /*
    class Vehicle  
    {
        public string brand = "Ford"; 
        public void honk()             
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
    class Car : Vehicle 
    {
        public string modelName = "Mustang"; 
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar object
            Car myCar = new Car();
            myCar.honk();
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
    */
    // POLYMORPHISM
    /*
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }
    */
    // ABSTRACTION
    /*
    abstract class Animal
    {
      public abstract void animalSound();
      public void sleep()
      {
        Console.WriteLine("Zzz");
      }
    }
    class Pig : Animal
    {
      public override void animalSound()
      {
        Console.WriteLine("The pig says: wee wee");
      }
    }
    class Program
    {
      static void Main(string[] args)
      {
        Pig myPig = new Pig(); 
        myPig.animalSound();  
        myPig.sleep();  
      }
    }
    */
    // INTERFACE
    /*
    interface IAnimal
    {
        void animalSound();
    }
    class Pig : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            myPig.animalSound();
        }
    }
        interface IFirstInterface
    {
        void myMethod(); 
    }
    interface ISecondInterface
    {
        void myOtherMethod(); 
    }
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();
        }
    }
    */
    // ENUMS
    /*
    enum Level
    {
        Low,
        Medium,
        High
    }
    class Program
    {
        static void Main(string[] args)
        {
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);
        }
    }
    class Program
    {
        enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July
        }

        static void Main(string[] args)
        {
            int myNum = (int)Months.April;
            Console.WriteLine(myNum);
        }
    }
    */
    // FILES
    /*
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World!"; 
            File.WriteAllText("dane.txt", writeText);  

            string readText = File.ReadAllText("dane.txt"); 
            Console.WriteLine(readText); 
        }
    }
    */
    // FILES
    /*
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World!"; 
            File.WriteAllText("dane.txt", writeText);  

            string readText = File.ReadAllText("dane.txt"); 
            Console.WriteLine(readText); 
        }
    }
    */
    // EXCEPTIONS
    /*
    class Program
  {
    static void Main(string[] args)
    {
      try
      {
        int[] myNumbers = {1, 2, 3};
        Console.WriteLine(myNumbers[10]);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }    
    }
  }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }
    class Program
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

        static void Main(string[] args)
        {
            checkAge(15);
        }
    }
    */
}