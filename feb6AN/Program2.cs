using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feb6AN
{
    class Program2
    {
        public static void Main()
        {

            int a = 1;
            Console.WriteLine(a); //1
            a++;    //a++ means a=a+1=2   use a first and then increment by1
            Console.WriteLine(a);//2
            a--;    //a-- means a=a-1=1
            Console.WriteLine(a); //1


            ++a;  //++a means a=a+1=2       
            Console.WriteLine(a);  //2

            int b = a;  // at this point b=2
            Console.WriteLine(a++); //2    after this a increment by 1 and becomes 3[incremented after writeline]
            Console.WriteLine(b);  //2
            b = b + 1;//3

            Console.WriteLine(++a);//4 so here a=a+1----->3+1=4[incremented before writeline]

            b = b + 1;
            Console.WriteLine(b);//4

        }
    }
}
