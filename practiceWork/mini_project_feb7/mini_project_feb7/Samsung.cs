using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_project_feb7
{
    // samsung class has all the features of smartphone and also advanced features of specific methods
    internal class Samsung:SmartPhone
    {
        public override void  Calling()                                     // overrides the calling function of smartphone
        {
            Console.WriteLine("calling in samsung HD.....");
        }
        public override void camera()                                                   // overrides the calling function of smartphone
        {
            Console.WriteLine("taking photo in samsung HDR......");
        }

        public void bixby()                                                 // special functionality of samsung
        {
            Console.WriteLine("turning on bixby....");
        }
       

        public void installing_apps(List<string> list)                      // overloading the installing_apps method with arguments list

        {
            Console.WriteLine("installing from PLAYSTORE");
            foreach(string item in list) Console.WriteLine(item);


        }








    }
}
