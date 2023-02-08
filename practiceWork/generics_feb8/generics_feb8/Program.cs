using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_feb8
{   
      
    //class which will hold the generic func

    public class GenericExample
    {
        
        public void add<T>(T Param1, T Param2)
        {
            
            Console.WriteLine($"Parameter1:{Param1},Parameter2:{Param2}");
            
        }
        public void add<Integer>(int Param1, int Param2)
        {
            int sum = Param2+ Param1;
            Console.WriteLine("sum: "+sum );

        }
        public void subtract<Integer>(int Param1, int Param2)
        {
            int sub = Param2 - Param1;
            Console.WriteLine("sum: " + sub);

        }



        public void emailGeneration<String,Integer>(string name, int special)
        {
            string generateEmail = name+ Convert.ToString(special);
            string email = "@gmail.com";
            Console.WriteLine(string.Concat(generateEmail, email));

        }




    }



    class students
    {
        public void GeneratedUSN<T>(T name, T special){

            string generateEmail = Convert.ToString(name) + Convert.ToString(special);
            string college = "@SMVIT";
            Console.WriteLine(string.Concat(generateEmail, college));
        }

    }


    internal class Program
    {   

        static void Main(string[] args)
        {
            GenericExample example = new GenericExample();
            students st = new students();

            st.GeneratedUSN("umer", "6767");

            example.add<int>(1, 2);

            example.emailGeneration<string,int>("umer", 6475);
            


        }
    }
}
