using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndertandingLINQApp
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Department_ID { get; set; }
        public override string ToString()
        {
            return Id + " " + Name + " " + Department_ID;
        }
    }
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Id + " " + Name;
        }
    }
    internal class Program
    {
        List<Department> departments = new List<Department>()
            {
                new Department{Id = 1, Name ="Admin"},
                new Department{Id = 2, Name ="Development"},
                new Department{Id = 3, Name ="Testing"},
            };
        List<Employee> employees = new List<Employee>()
           {
               new Employee{Id = 101,Name ="Tim",Department_ID=1},
               new Employee{Id = 102,Name ="Jim",Department_ID=2},
               new Employee{Id = 103,Name ="Kim",Department_ID=3},
               new Employee{Id = 104,Name ="Lim",Department_ID=2},
               new Employee{Id = 105,Name ="Pim",Department_ID=2},
               new Employee{Id = 106,Name ="Rim",Department_ID=1},
           };
        void LINQWithCollection()
        {
            //var myEmployees = employees.Where(e => e.Department_ID == 1);
            //foreach (var item in myEmployees)
            //{
            //    Console.WriteLine(item);
            //}
            //var myEmp = employees.SingleOrDefault(e => e.Id == 109);
            ////var myEmp = employees.Where(e => e.Id == 100).FirstOrDefault();
            //if (myEmp == null)
            //    Console.WriteLine("No such employee");
            //else
            //    Console.WriteLine(myEmp);
            var MyData = employees.Join(departments, emp => emp.Department_ID, dept => dept.Id,(emp,dept)=> new
            {
                EmployeeName =emp.Name,emp.Id,emp.Department_ID,DepartmentName = dept.Name
            })
                            .Where(e => e.Department_ID == 2|| e.Department_ID == 1)
                            .OrderBy(e=>e.Id)
                            .Select(
                                e => new
                                {
                                    e.EmployeeName,
                                    EmployeeId = e.Id,
                                    DepartmentName = e.DepartmentName
                                });
            foreach (var item in MyData)
            {
                Console.WriteLine("Employee ID : "+item.EmployeeId);
                Console.WriteLine("Employee Name : "+item.EmployeeName);
                Console.WriteLine("Department Name : " + item.DepartmentName);
            }

        }
        void SimpleWhere()
        {
            int[] scores = { 90, 67, 89, 100, 45, 69, 50, 88 };
            //List<int> results = new List<int>();
            //foreach (int score in scores)
            //{
            //    if (score > 70)
            //        results.Add(score);
            //}
            //var results = from s in scores where s > 70 select s;
            //var results = scores.Where(x => x > 70).ToList();
            //foreach (var item in results)
            //{
            //    Console.WriteLine(item);
            //}
            
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.SimpleWhere();
            program.LINQWithCollection();
            Console.ReadKey();
        }
    }
}
