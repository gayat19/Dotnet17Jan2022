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
    }
}
