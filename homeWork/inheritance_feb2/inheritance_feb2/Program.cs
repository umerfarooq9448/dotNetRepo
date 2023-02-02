using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_feb2
{
    class phone
    {
        public void calling()
        {
            Console.WriteLine("calling.....");
        }
        public void texting()
        {
            Console.WriteLine("texting.....");
        }

    }

    class smartphone : phone            // example of inheritance
    {
        public void camera()
        {
            Console.WriteLine("opening camera.....");
        }
    }

    class galaxy : smartphone               // example of multi level inheritance
    {
        public void hdRecording()
        {
            Console.WriteLine("hd recording.....");
        }
    }

    class smartphone2: phone        // example of multiple inheritance
    {
        public void lowResCamera() {

            Console.WriteLine("camera of low resoution....");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            smartphone s1 = new smartphone();   
            smartphone2 s2 = new smartphone2();
            galaxy g3 = new galaxy();
            s1.camera();
            s2.lowResCamera();
            g3.hdRecording();

        }
    }
}
