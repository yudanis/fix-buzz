using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Case number 1");
            MyClass myClass = new MyClass();
            myClass.addRule(3, "foo");
            myClass.addRule(5, "bar");
            myClass.print(15);

            Console.WriteLine("\nCase number 2");
            myClass.addRule(7, "jazz");
            myClass.print(35);

            Console.WriteLine("\nCase number 3");
            myClass.addRule(4, "baz");
            myClass.addRule(9, "huzz");
            myClass.print(35);

            Console.ReadLine();
        }
    }
}
