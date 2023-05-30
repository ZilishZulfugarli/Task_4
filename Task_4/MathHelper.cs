using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class MathHelper
    {
        public  int PrintValue(int a , int b)
        {
            return a + b;
        }

        public bool PrintValue(bool a)
        {
            
            if (true)
            {
                Console.WriteLine(1);
            }
            if (false)
            {
                Console.WriteLine(0);
            }
            return a ;
        }

        public string PrintValue(string a, string b) 
        {
            return a + b;
        }
        
        public int PrintValue(int a , int b , int c)
        {
            return a * b * c;
        }

    }
}
