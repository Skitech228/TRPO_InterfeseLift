using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class ConcreteStateBlocked : IState
    {
        public void Handle(Lift p)
        {
            Console.WriteLine($"Лифт {p.floar} без электричества");
        }
    }
}
