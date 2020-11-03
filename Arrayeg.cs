using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpbasics
{
    //One-Dimensional Array
    //data type[] arrname=new datatype[size];
    //data type[] arrname=new datatype[size]{value1,value2,..valueN};
    class Arrayeg
    {
        static void Main()
        {
            //One-Dimensional Array
            //data type[] arrname=new datatype[size];
            //new--allocates memory
            string[] flower = new string[5];//0,1,2,3
            flower[0] = "Lilly";
            flower[1] = "rose";
            flower[3] = "Jasmine";
            flower[2] = "Lotus";
flower[5] = "lavender";
            Console.WriteLine(flower[0]);
            for (int i = 0; i < flower.Length; i++)
            {
                Console.WriteLine("index{0}:{1}", i, flower[i]);
            }
            //int size = 4;
            int marks;
            Console.WriteLine("Enter size of index:");
            marks = Convert.ToInt32(Console.ReadLine());
            int[] index = new int[marks];
            for (int i = 0; i < index.Length; i++)
            {
                Console.WriteLine("Enter number:");
                index[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Read();

        }
    }
}
