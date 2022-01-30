using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_programs
{
    public class Test
    {
        public void leapYear()
        {
            Console.WriteLine("enter a year in yyyy");
            int y = Convert.ToInt32(Console.ReadLine());

            if ((y % 4 == 0) && (y % 100 != 0) || (y % 400 == 0))
            {
                Console.WriteLine("this year is leap year ");
            }
            else
            {
                Console.WriteLine("this year is not a leap year ");
            }

        }
    }
}
