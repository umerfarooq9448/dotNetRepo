using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_feb8
{
    internal class Program
    {
        public delegate int addnum(int a, int b);

        public delegate T addnum2<T>(T a, T b);




        public int add(int a, int b)
        {
            return (a + b);
        }

        public int add2<T>(T a, T b)
        {
            return(Convert.ToInt32(a) + Convert.ToInt32(b)); 
        }
        static void Main(string[] args)
        {
            Program ex = new Program();
            addnum obj = new addnum(ex.add);
            addnum2<int> obj2 = new addnum2<int>(ex.add2);

            Console.WriteLine(obj2(2, 3));


           Console.WriteLine( obj(1, 2));

            
        }
    }
}
