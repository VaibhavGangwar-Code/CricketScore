using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpbasics
{
    enum feedback
    {
        poor=1,good,fair,excellent
    }
    class Enumeratoneg
    {
        static void Main()
        {
                string Ename = "Wolverine";
                Console.WriteLine("name:{0}||feedback:{1}", Ename, (int)feedback.good);
                Console.WriteLine("name:{0}||feedback:{1}", Ename, feedback.good);
                Console.WriteLine("ame:{0}||feedback:{1}", Ename, Convert.ToInt32(feedback.good));
                Console.Read();
         }
    }
}
