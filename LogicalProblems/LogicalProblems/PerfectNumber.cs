using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class PerfectNumber
    {
        public static void perfectNumber()
        {
            int min, max, i, count;
            int a;

            Console.WriteLine("ENTER INITIAL NUMBER :");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER FINAL NUMBER :");
            max = Convert.ToInt32(Console.ReadLine());

            //finding perfect number within given numbers
            //using for loop
            for (i = min; i <= max; i++)
            {
                a = 1;
                count = 0;
                while (a < i)
                {
                    if (i % a == 0)
                        count = count + a;
                    a++;
                }
                if (count == i)
                    Console.Write("{0} ", i);
            }

        }
    }
}
