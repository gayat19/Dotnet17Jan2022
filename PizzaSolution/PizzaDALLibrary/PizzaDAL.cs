using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using PizzaModelsLibrary;

namespace PizzaDALLibrary
{
    public class PizzaDAL
    {
        SqlConnection conn;
        public PizzaDAL()
        {
            conn = MyConnection.GetConnection();
        }
       /// <summary>
       /// Gets all the records from teh table in the Pizza database
       /// </summary>
       /// <returns>
       ///      ICollection&lt;Pizza&gt;
       /// </returns>
       /// <exception cref="NoPizzaException"></exception>
        public ICollection<Pizza> GetAllPizzas()
        {
            List<Pizza> pizzas = new List<Pizza>(); 
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("proc_GetAllPizzas", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.Fill(ds);
            Pizza pizza;
            if (ds.Tables[0].Rows.Count == 0)
                throw new NoPizzaException();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                pizza = new Pizza();
                pizza.Id = Convert.ToInt32(item[0]);
                pizza.Name = item[1].ToString();
                pizza.IsVeg = Convert.ToBoolean(item[2]);
                pizza.Price = float.Parse(item[3].ToString());
                pizzas.Add(pizza);
            }
            return pizzas;
        }
        public bool InsertNewPizza(Pizza pizza)
        {
            SqlCommand cmd = new SqlCommand("proc_InsertPizza", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pname", pizza.Name);
            cmd.Parameters.AddWithValue("@veg", pizza.IsVeg);
            cmd.Parameters.AddWithValue("@pprice", pizza.Price);
            conn.Open();
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool UpdatePizzaPrice(int id,float price)
        {
            SqlCommand cmd = new SqlCommand("proc_UpdatePizzaPrice", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", id);
            cmd.Parameters.AddWithValue("@pprice", price);
            conn.Open();
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
    }
}
