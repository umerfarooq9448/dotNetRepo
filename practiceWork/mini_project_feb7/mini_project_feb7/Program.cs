using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_project_feb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Iiphone iphone = new Iiphone();
                iphone.camera();                                                                    // calling the overriden method of the camera in Iiphone class
                Samsung samsung1 = new Samsung();
                samsung1.camera();                                                                 // calling the overriden method of the camera in samsung class

                List<string> list = new List<string>() { "outlook", "skype", "whatsapp" };

                

                samsung1.installing_apps(list);                                                     //passing the list to the installing_apps of both the classes
                                       
                iphone.installing_apps(list);

            }
			catch (Exception exception)
			{
                Console.WriteLine(exception.Message);
                
			}
        }
    }
}
