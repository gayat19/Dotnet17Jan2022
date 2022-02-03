using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEFApplication
{
    internal class Program
    {
        readonly pubsEntities _entities;
        public Program()
        {
            _entities = new pubsEntities();
        }
        void PrintAuthors()
        {
            var authors = _entities.authors.ToList();
            foreach (var auth in authors)
            {
                Console.WriteLine(auth.au_id);
                Console.WriteLine(auth.au_fname+" "+auth.au_lname);
                Console.WriteLine(auth.address);
                Console.WriteLine(auth.state);
                Console.WriteLine("---------------------------");
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.PrintAuthors();
            Console.ReadKey();
        }
    }
}
