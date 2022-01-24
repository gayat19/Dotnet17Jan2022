using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaModelsLibrary
{
    public class GoldCustomer : Customer
    {
        public GoldCustomer()
        {
            MinimumAmount = 0;
            Type = "Gold";
        }
        public override string ToString()
        {
            return base.ToString()+" Minimum amount for delivery is 0";
        }
        public override void TakeCustomerDetailsFromUser()
        {
            base.TakeCustomerDetailsFromUser();
            Console.WriteLine("Please enter your preferred minimum amount");
            //MinimumAmount = Convert.ToInt32(Console.ReadLine());
            int amount = 0;
           while(!Int32.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Could not get the amount. Please try again.....");
            }
           
        }
    }
}
