using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberS = Console.ReadLine();
            int number = Convert.ToInt32(numberS);
            int i = 0;

            while (i < number)
            {
                Console.WriteLine(fibonachi(i));
                i++;
            }
            Console.ReadLine();
        }

        static int fibonachi(int n)
        {
            int k = 0;
            if (n < 1)
                k = 0;
            if (n == 1)
                k = 1;
            if (n >= 2)
            {
                k = fibonachi(n - 1) + fibonachi(n - 2);
            }
                return k;
        }
    }
}
