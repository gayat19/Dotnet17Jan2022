using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaModelsLibrary
{
    public  class CartPizzas
    {
        [ForeignKey("CartNumber")]
        public Cart Cart { get; set; }

        public int CartNumber { get; set; }
        [ForeignKey("PizzaId")]
        public Pizza Pizza { get; set; }
        public int PizzaId { get; set; }
        public int Quantity { get; set; }
    }
}
