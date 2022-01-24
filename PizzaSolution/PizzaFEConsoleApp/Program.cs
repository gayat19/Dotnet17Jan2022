using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PizzaFEConsoleApp
{
    internal class Program
    {
       
        void manageMenu()
        {
            Console.WriteLine("Welcome to menu management");
            int choice = 0;
            ManageMenu menu = new ManageMenu();
            do
            {
                Console.WriteLine("1: Add 3 pizzas");
                Console.WriteLine("2: Edit Pizza Price");
                Console.WriteLine("3: Remove Pizza");
                Console.WriteLine("4: Print a pizza detail");
                Console.WriteLine("5: Print All pizzas detail");
                Console.WriteLine("0: Exit");
                while(!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Try again. Please enter a number");
                }
                switch (choice)
                {
                    case 1:
                        menu.AddPizzas();
                        break;
                    case 2:
                        menu.EditPizzaPrice();
                        break;
                    case 3:
                        menu.RemovePizza();
                        break;
                    case 4:
                        menu.PrintSinglePizzaByID();
                        break;
                    case 5:
                        menu.PrintPizzas();
                        break;
                    case 0:
                        Console.WriteLine("Bey bye..........");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again");
                        break;
                }
            } while (choice != 0);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.manageMenu();
            Console.ReadKey();
        }
    }
}
