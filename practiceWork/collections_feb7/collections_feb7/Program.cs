using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections_feb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object first = 1 ;
            object second = 2 ;
            object third = 2;

            object str1= "test" ;
            object str2= "test" ;

            //Console.WriteLine(object.ReferenceEquals( second, third));
            //Console.WriteLine(object.Equals( second,third)) ;

            Console.WriteLine(object.ReferenceEquals(str1, str2));
            Console.WriteLine(object.Equals(str1, str2));
            Console.WriteLine(str1.GetHashCode());

            
            


        }
    }
}
