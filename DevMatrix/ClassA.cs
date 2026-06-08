using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrix
{
    public class ClassA
    {
        public void ClassAInfo()
        {
            //Console.WriteLine("This is ClassA in DevMatrix.");
            //////data types
            ////int tobi = 1887888888;
            ////string word = "Hello";
            ////bool isEaten = false;
            ////double figures = 664.78;
            ////char z = 'A';
            ////decimal tr = 1234567890.123456789m;
            ////float ty = 4.2F;
            ////long y = 1234567890123456789;
            ////short g = 23345;
            ////byte h = 66;

            Console.WriteLine("Welcome to the Coffee App. What would you like to order?");
            Console.WriteLine("1. BlackCoffee = 2500");
            Console.WriteLine("2. Cappuccino = 3500");
            Console.WriteLine("3. Expresso = 1500");
            Console.WriteLine("4. Americano = 500");
            Console.WriteLine("5. Braed = 1250"); 
            Console.WriteLine("6. Tea = 300");

            //string choice = Console.ReadLine();

            //implicit conversion
            int x = 2;
            long y = x;
            Console.WriteLine(y);

            //explicit conversion
            double a = 3.445;
            int b = (int)a;
            Console.WriteLine(b);

        }
    }
}
