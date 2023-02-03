using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_feb3
{
    internal class Program
    {
        public string model;

        public Program() {
            model = "audi";
        
        }    
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.model);
        }
    }
}
