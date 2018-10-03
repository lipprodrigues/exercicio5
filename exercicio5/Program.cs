using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            while (x <= 10)
            {
                Console.WriteLine("2x" + x + "=" + (x + x));
                x = x + 1;
            }
            Console.ReadKey();
        }
    }
}
