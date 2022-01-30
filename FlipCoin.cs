using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_programs
{
    public class FlipCoin
    {
        const double CHECK = 0.5;
        double headcount = 0, tailcount = 0;
        public void flips()
        {
            Random random = new Random();
            Console.WriteLine("flip coins");
            int number =Convert.ToInt32(random.Next());
            for (int i = 0; i < number; i++)
            {
                double option=random.NextDouble();
                if (option < CHECK)
                    headcount++;
                else
                {
                    tailcount++;
                }

            }
            Console.WriteLine("headcount percentage" + (headcount / number * 100));
            Console.WriteLine("tailcount percentage"+(tailcount / number * 100));
            
        }
    }
}
