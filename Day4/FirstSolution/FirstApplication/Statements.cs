using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    internal class Statements
    {
        public void UnderstandingSelectionWithIf()
        {
            int number1;
            Console.WriteLine("Pleae enter the  number");
            number1 = Convert.ToInt32(Console.ReadLine());
            if(number1==0)
                Console.WriteLine("It is Zero");
            else if(number1>100)
                Console.WriteLine("Good");
            else
                Console.WriteLine("I dont know what to say");
        }
        public void UnderstandingSelectionWithSwitch()
        {
            int number1;
            Console.WriteLine("Pleae enter the  number");
            number1 = Convert.ToInt32(Console.ReadLine());
            switch (number1)
            {
                case 0:
                    Console.WriteLine("It is Zero");
                    break;
                case 100:
                    Console.WriteLine("Good");
                    break;
                case 1000:
                    Console.WriteLine("Very Good");
                    break;
                default:
                    Console.WriteLine("Not a valid input");
                    break;
            }
        }
        public void IterationWithFor()
        {
            Console.WriteLine("For");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void IterationWithWhile()
        {
            Console.WriteLine("Understanding While");
            int i = 10;
            while (i<3)
            {
                Console.WriteLine(i);
                i = i + 1;
            }
        }
        public void IterationWithDoWhile()
        {
            Console.WriteLine("Understanding While");
            int i = 10;
            do
            {
                Console.WriteLine(i);
                i = i + 1;
            } while (i < 3);
        }
    }
}
