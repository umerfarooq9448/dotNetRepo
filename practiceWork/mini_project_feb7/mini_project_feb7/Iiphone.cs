using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_project_feb7
{

    // Iiphone class has all the features of smartphone and also advanced features of specific methods
    internal class Iiphone:SmartPhone
    {
       public override void  camera()                                                   // overrides the calling function of smartphone
        {
            Console.WriteLine("taking photo in iphone HDR......");
        }

        public void siri()                                                              // special functionality of samsung
        {
            Console.WriteLine("turning on siri.....");
        }

        public void installing_apps(List<string> list)                                  // overloading the installing_apps method with arguments list

        {

            Console.WriteLine("installing apps from APP STORE.....");
            

            for(int i=0; i<list.Count; i++)
            {
                Console.WriteLine((i+1)+" "+list[i]);
            }


        }
    }
}
