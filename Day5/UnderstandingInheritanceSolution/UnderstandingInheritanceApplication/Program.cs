using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritanceApplication
{
    internal class Program
    {
        void UsePhone(Phone phone)
        {
            //It has to behave like a phone is phone object is passed
            //It has to behave like a MobilePhone if mobilephone object is passed
            phone.MakeCall();
            phone.ReceiveCall();
            
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Phone phone = new MobilePhone();
            program.UsePhone(phone);
            Console.ReadKey();
        }
    }
}
