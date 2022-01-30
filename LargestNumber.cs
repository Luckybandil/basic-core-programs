using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_programs
{
    public class LargestNumber
    {
        public void largenumber()
        {
            int a, b, c, temp, Largest;
            Console.WriteLine("enter the first number");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int y=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number");
            int z=Convert.ToInt32(Console.ReadLine());

            temp = x > y ? x : y;
            Largest = c > temp ? c : temp;
            Console.WriteLine("the laregest number is " +Largest);
        }

    }
}
