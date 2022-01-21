using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PizzaFEConsoleApp
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            ManageCustomer program = new ManageCustomer();
            program.RegisterCustomer();
            program.DisplayCustomer();
            Console.ReadKey();
        }
    }
}
