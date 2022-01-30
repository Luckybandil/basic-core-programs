using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_programs
{
    public class QuotientandReminder
    {
        public void quotremd()
        {
			int x, y, q, r;
			Console.WriteLine("Enter first number:");
			x = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter second number:");
			y = Convert.ToInt32(Console.ReadLine());

			q = x / y;
			r = x % y;

			Console.WriteLine("Quotient is:" + q);
			Console.WriteLine("Remainder is:" + r);
		}
    }
}
