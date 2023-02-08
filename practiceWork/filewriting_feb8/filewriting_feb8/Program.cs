using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace filewriting_feb8
{
    internal class Program
    {
        class FileWrite
        {


            public void WriteData()
            {
                FileStream fs = new FileStream("test.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                Console.WriteLine("enter the text which should be writen in the file");
                string str = Console.ReadLine();
                sw.WriteLine(str);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }


        class FileRead
        {
            public void ReadData(string val)
            {

                FileStream fs = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
                StreamReader Sr = new StreamReader(fs);
                Console.WriteLine("Showing the content of file:");

                if (val == "1")
                {
                    Sr.BaseStream.Seek(0, SeekOrigin.Begin);

                }
                else if(val=="2"){
                    Sr.BaseStream.Seek(0, SeekOrigin.Current);
                }
                else
                {
                    Sr.BaseStream.Seek(0, SeekOrigin.End);

                }

                

                string str = Sr.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    str =Sr.ReadLine(); 
                }

                Console.ReadLine();
                Sr.Close();
                fs.Close();

            }
             

        }
        static void Main(string[] args)
        {
            //FileWrite fs = new FileWrite();
            //fs.WriteData();


            Console.WriteLine("enter the text file name");
            string text_file_name = Console.ReadLine();

            

            

            

            try
            {
                if (File.Exists("test.txt"))
                {
                    Console.WriteLine("how do you want to do /n 1.Begin /n 2.current /n 3.end");



                    string val = Console.ReadLine();
                    FileRead fr = new FileRead();

                    fr.ReadData(val);
                }
                else
                {
                    Console.WriteLine("create a file");

                    FileWrite fr = new FileWrite();
                    fr.WriteData();
                }
                

            }
            catch(Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}
