using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class MyClass
    {
        Dictionary<int, string> rules;
        public MyClass()
        {
            rules = new Dictionary<int, string>();
            
        }
        public void addRule(int input, string output)
        {
            this.rules.Add(input, output);
        }
        
        public void print(int maxNumber)
        {
            
            for (int i = 1; i <= maxNumber; i++)
            {
                string display = "";
                foreach (KeyValuePair<int, string> rule in rules)
                {
                   if(i % rule.Key == 0)
                        display+= rule.Value;
                }

                if (display == "")
                    Console.Write("" + i +", ");
                else
                    Console.Write(display + ", ");
            }
        }
    }
}
