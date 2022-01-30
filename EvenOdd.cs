using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_programs
{
    public class EvenOdd
    {
        public void evod()
        {
            Console.WriteLine("enter the value");
            int value = Convert.ToInt32(Console.ReadLine());
            
            if (value % 2 == 0)
            {
                Console.WriteLine("print even number" +value);
            }
            else
            {
                Console.WriteLine("print odd number"+value);

            }
        }

    }
    
}
