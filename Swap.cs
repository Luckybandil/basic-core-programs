using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_programs
{
    public class Swap
    {
        public void swp()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("before swap" + a + "b=" + b);
            int temp=a;
            a = b;
            b = temp;
            Console.WriteLine("after swap" +a+ "b=" + b);
        }
    }
}
