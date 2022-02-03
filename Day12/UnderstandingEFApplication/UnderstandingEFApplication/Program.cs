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
        void InsertStore()
        {
            store store = new store();
            store.stor_id = "1234";
            store.stor_name = "ABCD";
            store.stor_address = "here";
            store.city = "Tustin";
            store.state = "CA";
            store.zip = "92789";
            _entities.stores.Add(store);
            _entities.SaveChanges();
            Console.WriteLine("Store addeed");
        }
        void EditStore()
        {
            store store = _entities.stores.FirstOrDefault(s => s.stor_id == "1234");
            if (store == null)
            {
                Console.WriteLine("No such store");
                return;
            }
            store.stor_name = "XYZ";
            _entities.SaveChanges();
            Console.WriteLine("Store updated");
        }
        void RemoveStore()
        {
            store store = _entities.stores.FirstOrDefault(s => s.stor_id == "1234");
            if (store == null)
            {
                Console.WriteLine("No such store");
                return;
            }
            _entities.stores.Remove(store);
            _entities.SaveChanges();
            Console.WriteLine("Store deleted");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.RemoveStore();
            Console.ReadKey();
        }
    }
}
