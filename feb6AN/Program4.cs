using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feb6AN
{
    class Program4
    {
        public static void Main()
        {
            Console.WriteLine(System.Math.Ceiling(14.1)); //15
            Console.WriteLine(System.Math.Floor(20.9)); //20

            Console.WriteLine(System.Math.Round(3.5));  //4
            Console.WriteLine(System.Math.Round(3.8543,2)); //3.85
           // Console.WriteLine(System.Math.Ceiling(3.8543, 2));  **error here

        }

    }
}
