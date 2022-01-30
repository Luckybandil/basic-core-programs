using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_programs
{
    public class PrimeEven
    {
        public void Primeno()
        {
            Console.WriteLine("enter the prime number");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            while (num > i)
            {
                if (num % 2 == 0)
                {
                    break;
                }
                i++;
            }
                if (num == i)
                {
                    Console.WriteLine("this is prime number");
                }
                else
                {
                  Console.WriteLine("this is not a prime number");
                }
            
        }

    }
}
