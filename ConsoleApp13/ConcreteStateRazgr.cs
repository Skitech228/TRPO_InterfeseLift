using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class ConcreteStateRazgr : IState
    {
        public void Handle(Lift p)
        {
            Console.WriteLine($"Лифт разгружаеться на этаже {p.floar}");
        }
    }
}
