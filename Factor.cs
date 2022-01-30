using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_programs
{
    public  class Factor
    {
        public void fac()
        {
            int number;
            Console.WriteLine("enter the number");
            int number=Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < number; i++)
            {
                while (number%i==0)
                {
                    Console.WriteLine(i + "  ");
                    number=number/i;
                   }
            }
            if (number > 2)
            {
                Console.WriteLine(number);

            }
        }
    }
}
