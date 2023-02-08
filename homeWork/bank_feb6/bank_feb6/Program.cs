using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace bank_feb6
{
    class bank
    {
        public int id;
        private int credit_score;
        public string name, phone_number;
        private string salary;


         public void personal(int id, string name, string phone)
        {
            this.id = id;
            this.name = name;
            this.phone_number = phone;
        }
        public void salary_details(string salary, int credit_score)
        {
            this.credit_score = credit_score;
            this.salary = salary;   
        }

    }

    class creditCard 
    {
        public creditCard(string salary, int credit_score)
        {   
            bank b = new bank();
            b.salary_details(salary, credit_score); 
            
            

        }
        public creditCard(int id1, string name, string phone)
        {
            bank b = new bank();
            b.personal( id1, name, phone);
           


        }
    }
    class TPV: bank
    {
       public int get_id() { return id; }
       public string get_name() { return name; }

        public string get_phone_number() { return phone_number; }
        
}

    internal class Program
    {
        static void Main(string[] args)
        {
            bank b = new bank();
            
            TPV t = new TPV();
            creditCard c = new creditCard(3, "aa", "85949");
            Console.WriteLine(t.id);
            
        }
    }
}
