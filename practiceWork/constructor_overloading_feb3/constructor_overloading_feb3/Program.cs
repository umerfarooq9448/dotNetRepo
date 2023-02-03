using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_overloading_feb3
{
    internal class Program

    {
        int x, y;
        double f;
        string s;
        public Program(int a, double b) { 
        
            x= a;
            f= b;
        
        }
        public Program(int a, string s)
        {
            Console.WriteLine("roll no is= "+s)
        }
        
        static void Main(string[] args)
        {
        }
    }
}
