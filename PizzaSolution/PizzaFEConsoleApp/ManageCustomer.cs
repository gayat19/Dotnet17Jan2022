using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaModelsLibrary;

namespace PizzaFEConsoleApp
{
    internal class ManageCustomer
    {
        Customer[] customers = new Customer[3];
        public void RegisterCustomer()
        {
            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine("Please enter the customer type Standard/Gold");
                Customer customer;
                string type = Console.ReadLine();
                switch (type)
                {
                    case "Standard":
                        customer = new Customer();
                        break;
                    case "Gold":
                        customer = new GoldCustomer();
                        break;
                    default:
                        Console.WriteLine("Invalid Entry. Treating as standard");
                        customer = new Customer();
                        break;
                }
                customers[i] = customer;
                customers[i].TakeCustomerDetailsFromUser();
            }
        }
        public void DisplayCustomer()
        {
            //customer.PrintCustomerDetails();
            Array.Sort(customers);
            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine(customers[i]);
            }
        }

    }
}
