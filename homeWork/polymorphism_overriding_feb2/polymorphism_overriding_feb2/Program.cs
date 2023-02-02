using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_overriding_feb2
{
    class operation
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

    }
    class child_operations:operation
    {
        public void add(int a, int b, int c) {

            Console.WriteLine(a + b+c);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            child_operations op = new child_operations();
            
            op.add(2, 3);
            op.add(3, 4,1);
            Console.ReadLine();
        }
    }
}
