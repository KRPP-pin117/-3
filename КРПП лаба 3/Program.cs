using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КРПП_лаба_3
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            long a2;
            a = (long) Math.Pow(2, 60);
            
            double count = 60;
            Console.WriteLine("С одной амебой  " + a);

            for (int i = 2; count > i; i++)
            {
                a2 = (long) Math.Pow(2, i);
                Console.WriteLine("С двумя амебами  " + a2);

            }

            Console.ReadLine();



        }
    }
}
