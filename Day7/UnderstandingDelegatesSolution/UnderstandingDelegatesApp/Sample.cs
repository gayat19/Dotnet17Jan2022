using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingDelegatesApp
{
    internal class Sample
    {

        //Action-for methods with or without paramenter but no return
        //Func for methods with or without parameters with one return type
        //Predicate - for methods with one parameter with a boolean return type


        //public delegate void SampleDelegate(int n1,int n2);
        //public delegate void SampleDelegate<T>(T n1, T n2);
        //public SampleDelegate<int> MyDel;
        //public SampleDelegate<string> MyStringDel;
        public Action<int, int> MyDel;
        public Action<string, string> MyStringDel;
        public Sample()
        {
            //MyDel = new SampleDelegate(Add);
            MyDel = delegate (int n1, int n2)
            {
                Console.WriteLine("The sum is " + (n1 + n2));
            };
            //MyDel += Product;
            //MyDel += delegate (int n1, int n2)
            //{
            //    Console.WriteLine("The product is " + (n1 * n2));
            //};
            MyDel += (n1, n2) => Console.WriteLine("The product is " + (n1 * n2));
            //MyStringDel = new SampleDelegate<string>(Add);
            MyStringDel = Add;
        }
        void Add(int num1,int num2)
        {
            int sum = num1+ num2;
            Console.WriteLine("The sum is "+sum);
        }
        void Add(string num1, string num2)
        {
            string sum = num1 + num2;
            Console.WriteLine("The result is " + sum);
        }
        //void Product(int num1, int num2)
        //{
        //    int sum = num1 * num2;
        //    Console.WriteLine("The product is " + sum);
        //}

    }
}
