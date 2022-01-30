using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_programs
{
    public  class PowerByTwo
    {
        public void powtwo()
        {
            Console.WriteLine("enter the powervalue");
            int value=Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= value; i++)
            {
                if (value % i == 0 && i == 2)
                {
                    Console.WriteLine("even prime fac" + i);
                    return;
                }
                if (value % i == 1 && value % i != 2)
                {
                    Console.WriteLine("prime fac" + i);
                }
            }
        }
    }
}
