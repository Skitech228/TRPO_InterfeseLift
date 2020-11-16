using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Представляет состояния
namespace ConsoleApp13
{
    public interface IState
    {
        void Handle(Lift p);
    }
}
