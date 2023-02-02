using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_function_overloading_feb2
{   
    class operation
    {
        public void add(int a,int b)
        {
            Console.WriteLine(a+b);
        }

        public void add(int a, int b, int c)   //-------> exmaple of method overloading
        {
            Console.WriteLine(a + b + c);
        }

    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            operation op = new operation();
            op.add(1,2);
            op.add(2,3,2);
            Console.ReadLine();
        }
    }
}
