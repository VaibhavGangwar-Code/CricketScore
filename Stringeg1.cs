using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpbasics
{
    class Stringeg1
    {
        static void Main()
        {
            string firstname = "venkata manoj vatadi";
            Console.WriteLine("lenght of the string {0}:", firstname.Length);
            Console.WriteLine("converting to Uppercase {0}", firstname.ToUpper());
            Console.WriteLine("firstname contains {0}:", firstname.Contains("man"));
            Console.WriteLine("index: {0}:", firstname.IndexOf("a"));
            Console.Read();
        }
    }
}
