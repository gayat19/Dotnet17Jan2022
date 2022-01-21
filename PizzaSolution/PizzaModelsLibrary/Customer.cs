using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaModelsLibrary
{
    public class Customer
    {
        
        public int MinimumAmount { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }
        private string phone;

        public string Phone
        {
            get
            {
                string masked = "XXXXXX" + phone.Substring(6, 4);
                return masked;
            }
            set
            {
                phone = value;
            }
        }
        public Customer()
        {
            MinimumAmount = 100;
            Type = "Standard";
        }
        public void TakeCustomerDetailsFromUser()
        {
            Console.WriteLine("Please enter the customer ID");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enetr the Customer Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the Customer Phone");
            Phone = Console.ReadLine();
        }
        public void PrintCustomerDetails()
        {
            Console.WriteLine("Customer ID {0} Customer Name {1} Customer Phone {2}",Id,Name,Phone);
        }
        public override string ToString()
        {
            return "Customer ID "+Id+"\nCustomer Name "+Name+"\nCustomer Phone "+Phone+"\nCustomer Type "+Type;
        }

    }
}
