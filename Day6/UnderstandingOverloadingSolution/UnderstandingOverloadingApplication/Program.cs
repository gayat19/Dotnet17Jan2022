using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOverloadingApplication
{
    internal class Program
    {
        Program()
        {
            Console.WriteLine("Default Constructor");
        }
        Program(int i)
        {
            Console.WriteLine("Parameterized constructor");
        }
        void Add(int num1,int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("The sum of {0} and {1} is {2}",num1,num2,sum);
        }
        void Add(int num1)
        {
            int sum = num1++;
            Console.WriteLine("The incremented value of  {0} is {1}", num1, sum);
        }
        void Add(string str1,string str2)
        {
            string res = str1 +" "+ str2;
            Console.WriteLine("The concat value of of {0} and {1} is {2}", str1, str2, res);
        }
        static void Main(string[] args)
        {
            //Program program = new Program();
            //program.Add("Hello", "World");
            //program.Add(10, 20);
            //program.Add(20);
            Employee employee = new Employee();
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(employee[i]);
            //}
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            e1[0] = "Java";
            Employee e3 =e1 + e2;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(e3[i]);
            }
            Console.WriteLine("The index of skill MS SQL is "+employee["MS SQL"]);
            Console.ReadKey();
        }
    }
}
