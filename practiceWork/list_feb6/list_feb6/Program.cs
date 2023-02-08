using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_feb6
{
   class student
    {
        public int id;
        public string name; 
        public int age;
        public string city;
        public string course;

        public  int get_id()
        {
            return id;
        }
        public string get_name()
        {
            return name;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new List <student>();
            {
                student.Add(new student { id=1,name="rohith",age=15,city="bangalore",course="AI"});
                student.Add(new student { id = 2, name = "umer", age = 15, city = "bangalore", course = "ML" });
                student.Add(new student { id = 3, name = "shraddha", age = 15, city = "bangalore", course = "DS" });
                student.Add(new student { id = 4, name = "mahesh", age = 15, city = "bangalore", course = ".net" });
                student.Add(new student { id = 5, name = "ismail", age = 15, city = "bangalore", course = "java" });
            }

            foreach(var st in student)
            {
                Console.WriteLine(st.id+"-"+st.name);
            }

        }
    }
}
