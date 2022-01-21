using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritanceApplication
{
    internal class MobilePhone : Phone
    {
        public MobilePhone()
        {
            Console.WriteLine("and Its mobile");
            PhoneNumber = "1234567890";
        }
        public void Carry()
        {
            Console.WriteLine("Take where you go....");

        }
        public override void MakeCall()
        {
            Console.WriteLine("Go wireless");
        }
    }
}
