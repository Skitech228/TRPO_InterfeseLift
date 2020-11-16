using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class ConcreteStatePer : IState
    {
        public void Handle(Lift p)
        {
            Console.WriteLine($"Лифт переместился на этаж {p.floar}");
        }
    }
}
