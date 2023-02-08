using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_project_feb7
{
    // class SmartPhone implements IBsaicPhone which has basic functionality and added functionality
    internal class SmartPhone : IBasicphone

    {
        public virtual void Calling()                               // implementation of interface
        {
            Console.WriteLine("calling.....");
        }

        public virtual void Messaging()                             // implementation of interface
        {
            Console.WriteLine("messaging......");
        }

        public virtual void OpenGps()                               // additional functionality
        {
            Console.WriteLine("gps turning on.....");

        }
        public virtual void camera()                                // additional functionality
        {
            Console.WriteLine("taking a photo......");
        }

        public virtual void taking_video()                           // additional functionality
        {
            Console.WriteLine("taking video.....");
        }
        public virtual void installing_apps()                          // additional functionality
        {                      

            Console.WriteLine("please write the apps to be installed.....");
                
        }
    }
}
