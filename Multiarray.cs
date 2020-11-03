using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpbasics
{
    class Multiarray
    {
        static void Main()
        {
            
            Console.WriteLine("enter no of rows");
            int row= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter no of columns");
            int column= Convert.ToInt32(Console.ReadLine());
            int[,] num = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.WriteLine("enter num:");
                    num[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.WriteLine(num[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.Read();
        }
    }
}
