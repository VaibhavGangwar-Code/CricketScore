﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpbasics
{
    class Boxingandunboxing
    {
        static void Main()
        {
            //value type
            int petrol = 100;
            //reference type
            //boxing converting value type to reference type
            object o = petrol;
            Console.WriteLine("boxing converting value type to reference type:{0}", o);
            //reference type to value type--unboxing
            string oil = "10";
            int oilprice = Convert.ToInt32(oil);
            Console.WriteLine("reference type to value type--unboxing :{0}", oilprice);
            Console.Read();
        }
    }
}
