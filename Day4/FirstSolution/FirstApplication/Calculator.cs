using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    internal class Calculator
    {
        int number1, number2;
        void TakeNumbers()
        {
            Console.WriteLine("Pleae enter the first number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pleae enter the second number");
            number2 = Convert.ToInt32(Console.ReadLine());
            //Converting input to float
            float fNum1 = float.Parse(Console.ReadLine());
        }
        public void Add()
        {
            TakeNumbers();
            int sum = number1 + number2;
            Console.WriteLine("The sum of "+number1+" and "+number2+" is "+sum);
        }
        public void Product()
        {
            TakeNumbers();
            int product = number1 * number2;
            Console.WriteLine("The product of " + number1 + " and " + number2 + " is " + product);
        }
    }
}
