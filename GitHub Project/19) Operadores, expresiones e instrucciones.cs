using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresExpresionesInstrucciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, a, b;

            x = 3;
            y = 2;
            a = 1;
            b = 0;


            x = 3 + 4;

            x = 10 - 5;

            x = 3 * 5;

            x = 10 / 5;

            x = (x + y) * (a - b);

            if (x == y)
            {
            }

            if (x > y)
            {
            }

            if (x < y)
            {
            }


            if ((x > y) && (a > b))
            {
            }

            if ((x> y) || (a > b))
            {
            }

            string message = (x == 1) ? "car" : "Boat";

            Console.WriteLine("hi");

        }
    }
}