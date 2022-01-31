using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaDALLibrary;
using PizzaModelsLibrary;

namespace PizzaFEConsoleApp
{
    internal class ManageMenu 
    {
        //Pizza[] pizzas;
        List<Pizza> pizzas;
        PizzaDAL pizzaDAL;
        public Pizza this[int index]
        {
            get { return pizzas[index]; }
            set { pizzas[index] = value; }
        }
        public ManageMenu()
        {
            //pizzas = new Pizza[3];
            //pizzas = new List<Pizza>();
            pizzaDAL = new PizzaDAL();
           
        }
        void GetAllPizzas()
        {
            pizzas = null;
            try
            {
                pizzas = pizzaDAL.GetAllPizzas().ToList();
            }
            catch (NoPizzaException npe)
            {
                Console.WriteLine(npe.Message);
            }
            catch (Exception npe)
            {
                Console.WriteLine("Something went wrong. Will fix soon...");
                Console.WriteLine(npe.Message);
            }
        }
        public ManageMenu(int size)
        {
            //pizzas = new Pizza[size];
        }
        public void AddPizzas()
        {
            //for (int i = 0; i < pizzas.Length; i++)
            //for (int i = 0; i < pizzas.Count; i++)
            //{
            //    int id = GenerateId();
            //    pizzas[i] = new Pizza();
            //    pizzas[i].Id = id;
            //    pizzas[i].GetPizzaDetails();
            //}
            Pizza pizza = new Pizza();
            //pizza.Id = GenerateId();
            pizza.GetPizzaDetails();
            //pizzas.Add(pizza);
            try
            {
                pizzaDAL.InsertNewPizza(pizza);
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not add the pizza");
                Console.WriteLine(e.Message);
            }
        }

        //private int GenerateId()
        //{
        //    //if(pizzas[0]==null)
        //    //    return 101;
        //    //else
        //    //{
        //    //    for (int i = 0; i < pizzas.Length; i++)
        //    //    {
        //    //        if (pizzas[i] == null)
        //    //            return 101 + i;
        //    //    }
        //    //}
        //    if(pizzas.Count == 0)
        //        return 101;
        //    return pizzas.Count+101;
        //}

        public Pizza GetPizzaById(int id)
        {
            //Pizza pizza = null;
            //for (int i = 0; i < pizzas.Length; i++)
            //for (int i = 0; i < pizzas.Count; i++)
            //{
            //    if(pizzas[i].Id==id)
            //        pizza = pizzas[i];
            //}
            //Predicate<Pizza> findPizza = p=>p.Id== id;
            //Pizza pizza = pizzas.Find(findPizza);
            GetAllPizzas();
            Pizza pizza = pizzas.SingleOrDefault(p => p.Id == id);
            return pizza;
        }
        public void EditPizzaPrice()
        {
            int id = GetIdFromUser();
            Pizza pizza = GetPizzaById(id);
            if(pizza == null)
            {
                Console.WriteLine("Invalid Id. Cannot edit");
                return;
            }
            Console.WriteLine("The pizza for you have chosen to edit price");
            PrintPizza(pizza);
            double price;
            Console.WriteLine("Please enter the new price");
            while (!double.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Invalid entry for price. Please try again...");
            }
            pizza.Price = price;
            if(pizzaDAL.UpdatePizzaPrice(id,((float)price)))
                Console.WriteLine("Updated. New Details");
            PrintPizza(pizza);
        }
        public void RemovePizza()
        {
            int id = GetIdFromUser();
            int idx = -1;
            ////for (int i = 0; i < pizzas.Length; i++)
            //for (int i = 0; i < pizzas.Count; i++)
            //{
            //    if (pizzas[i].Id == id)
            //        idx = i;
            //}
            try
            {
                idx = pizzas.SingleOrDefault(p => p.Id == id).Id;
            }
            catch (Exception)
            {
                Console.WriteLine("No such pizza");
            }
            Pizza pizza = GetPizzaById(id);
            if(idx != -1)
            {
                Console.WriteLine("Do you want to delete the following Pizza???");
                PrintPizza(pizza);
                string check = Console.ReadLine();
                if (check == "yes")
                    pizzas.RemoveAt(idx);
                    //pizzas[idx] = null;
            }
           
        }
        int GetIdFromUser()
        {
            Console.WriteLine("Please enter the pizza id");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid entry ID. Please try again...");
            }
            return id;
        }
        public void PrintPizzas()
        {
            //Array.Sort(pizzas);
            // pizzas.Sort();
            GetAllPizzas();
            var sortedPizzas = pizzas.OrderBy(p => p.Price);
            foreach (var item in sortedPizzas)
            {
                if(item != null)
                    PrintPizza(item);
            }
        }
        public void PrintSinglePizzaByID()
        {
            int id = GetIdFromUser();
            Pizza pizza = GetPizzaById(id);
            if (pizza != null)
            {
                PrintPizza(pizza);
            }
            else
                Console.WriteLine("No such pizza");
        }

        private void PrintPizza(Pizza item)
        {

            Console.WriteLine("**************************");
            Console.WriteLine(item);
            Console.WriteLine("**************************");
        }
    }
}
