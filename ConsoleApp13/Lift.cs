using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Lift
    {
        public int floar;
        public double carrying;
        public int ver;
        public IState State { get; set; }

        public Lift(int floar, double carrying)
        {
            this.floar = floar;
            this.carrying = carrying;
            Random r = new Random();
            this.ver = r.Next(0,100);
        }

        public void Request()
        {
            State.Handle(this);
        }

        public void Zagr()
        {
            Random r = new Random();
            if (this.carrying <= r.Next(30, 120))
            {
                this.ver = 100;
                this.State = new ConcreteStateBlocked();
                this.Request();
            }
            else
            {
                this.State = new ConcreteStateZagr();
                this.Request();
                this.Per();
            }
        }

        private void Per()
        {
            Console.WriteLine("Введите этаж для перехода");
            this.floar =int.Parse( Console.ReadLine());
            this.State = new ConcreteStatePer();
            this.Request();
            this.Razgr();
        }

        private void Razgr()
        {
            this.State = new ConcreteStateRazgr();
            this.Request();
        }

        public void VizovLifta()
        {
            Random r = new Random();
            if (this.ver <= r.Next(0, 100))
            {
                Console.WriteLine("Нет энергии");
                this.State = new ConcreteStateBlocked();
                this.Request();
            }
            else
            {
                Console.WriteLine("Введите этаж для перехода");
                this.floar = int.Parse(Console.ReadLine());
                this.State = new ConcreteStatePer();
                this.Request();
            }
        }

        public void VostanEn()
        {
            if (this.ver ==100)
            {
                this.State = new ConcreteStateVostan();
                this.Request();
                this.ver = 0;
            }
        }

    }
}
