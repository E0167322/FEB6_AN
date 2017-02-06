using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feb6AN
{
    class Program
    {
      public static void Main()
        {
            Console.Write("please enter a number");
            string input = Console.ReadLine();
            int numtix = Convert.ToInt16(input);
            
            Console.WriteLine("Total cost= {0}",numtix*25);
        }
    }
}
