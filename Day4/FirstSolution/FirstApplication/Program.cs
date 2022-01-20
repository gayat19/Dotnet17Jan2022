using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    internal class Program
    {
        //Method Header
       void PrintName()
        {//Method Body
            Console.WriteLine("Hello G3");
        }
        void PrintAnyName(string name)
        {
            Console.WriteLine("Hello "+name);
        }
        void Greet(string greet)
        {
            string name;
            Console.WriteLine("Please enter you name");
            name = Console.ReadLine();
            Console.WriteLine(greet+" "+name);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Program program = new Program();
            //program.PrintName();//Method call
            //program.Greet("Hi!!!");
            //Calculator calc = new Calculator();
            //calc.Add();
            //calc.Product();
            Statements s = new Statements();
            s.UnderstandingSelectionWithSwitch();
            //Pizza pizza = new Pizza();
            // pizza.name = "";
            Console.ReadKey();
        }
    }
 
}
