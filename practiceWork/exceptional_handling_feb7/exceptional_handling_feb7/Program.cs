using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptional_handling_feb7
{
    internal class Program:ISavingsAccount,ICurrentAccount
    {
        static void Main(string[] args)
        {
            try
            {
                var students = new List<string>() { "umer", "farooq" };    // initialize directly 
               /* students.Add("vishal");   
                students.Add("sumanth");                                   // initialize one by one
                students.Add("rohith");
                students.Add("umer");
                students.Add("shirly"); */

                
                
                //foreach(var student in students)                        // display list
                //{
                //    Console.WriteLine(student+" ");         
                //}

                for(int i=0; i<students.Count; i++)
                {
                    Console.WriteLine(students[i]+" " +i);
                }

                Program p = new Program();
                p.AddNewAccount();                                      // creation of object of implementation of interface 

            }
            catch (ArgumentException argx)
            {
                  Console.WriteLine(argx.Message);  
            }
            catch (IndexOutOfRangeException index){
                Console.WriteLine(index.Message);   
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
        }


        // Down are the the implemented method of interface
        public void AddNewAccount()
        {
            throw new NotImplementedException();
        }

        public void CreateCurrentAccount()
        {
            throw new NotImplementedException();
        }

        public void ShowBalance()
        {
            throw new NotImplementedException();
        }

        public void UpdateCurrentAccount()
        {
            throw new NotImplementedException();
        }
    }
}
