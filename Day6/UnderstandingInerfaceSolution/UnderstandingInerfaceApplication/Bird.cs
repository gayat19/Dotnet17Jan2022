using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInerfaceApplication
{
    internal class Bird : IFlying,ILiving
    {
        public Bird()
        {
            Console.WriteLine("You have created a bird");
        }
        public void Breathe()
        {
            Console.WriteLine("Breathe in.... Breathe out");
        }

        public void Eat()
        {
            Console.WriteLine("Munch mucch");
        }

        public void Fly()
        {
            Console.WriteLine("Fly Fly");
        }

        public void Land()
        {
            Console.WriteLine("Stop flapping wings");
        }

        public void Sleep()
        {
            Console.WriteLine("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz");
        }

        public void TakeOff()
        {
            Console.WriteLine("Flap wings fast");
        }
    }
}
