using System;

namespace string_feb3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string str = "hello";
            string str2 = "world";
            Console.WriteLine(str.Substring(2, 3));
            Console.WriteLine(string.Concat(str, str2));
            Console.WriteLine(str.CompareTo(str2));


            Console.WriteLine(str.Length);
            Console.WriteLine(str.IndexOf("e"));

            Console.WriteLine(str.LastIndexOf('l'));
            Console.WriteLine(str.Trim());
            string[] subs = str.Split('e');
            foreach (string st in subs)
            {
                Console.WriteLine($"Substring: {st}");
            }
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.Replace('l', 'n'));

        }
    }
}
