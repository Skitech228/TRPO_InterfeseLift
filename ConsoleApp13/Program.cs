using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Lift p = new Lift(3, 100);
            p.Zagr();
            p.VizovLifta();
            p.VizovLifta();
            p.VostanEn();
            Console.ReadKey();
        }
    }
}
