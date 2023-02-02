using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_feb2
{
    abstract class phone{
        public abstract void calling();
        public abstract void texting();
        }
    class smartphone : phone
    {
        public override void calling()
        {
            Console.WriteLine("calling");
        }

        public override void texting()
        {
            Console.WriteLine("texting");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            smartphone s1 = new smartphone();
            s1.calling();
            s1.texting();
        }
    }
}
