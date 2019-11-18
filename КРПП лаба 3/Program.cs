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
            a2 = a + 1;
            Console.WriteLine("С одной амебой  " + a);
            Console.WriteLine("С двумя амебами  " + a2);
            Console.ReadLine(); 

        }
    }
}
