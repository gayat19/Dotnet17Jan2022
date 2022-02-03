using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaModelsLibrary
{
    public class Cart
    {
        [Key]
        public int CartNumber { get; set; }
        public int CustomerRef { get; set; }

        [ForeignKey("CustomerRef")]
        public Customer Customer { get; set; }
        public ICollection<Pizza> Pizzas { get; set; }
    }
}
