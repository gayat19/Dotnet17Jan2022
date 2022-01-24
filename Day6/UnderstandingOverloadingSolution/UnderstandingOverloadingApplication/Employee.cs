using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOverloadingApplication
{
    internal class Employee
    {
        string[] skills = new string[3];
        public Employee()
        {
            skills[0] = "C#";
            skills[1] = "MS SQL";
            skills[2] = "DevOps";
        }
        public string this[int index]
        {
            get { return skills[index]; }
            set { skills[index] = value;  }
        }
        public int this[string sname]
        {
            get { 
                int idx = -1;
                for (int i = 0; i < skills.Length; i++)
                    if (skills[i] == sname)
                        idx = i;
                return idx;
            }
        }
        public static Employee operator +(Employee e1, Employee e2)
        {
                Employee e = new Employee();
                for (int i = 0; i < e.skills.Length; i++)
                {
                    if (e1[i] != e2[i])
                    {
                        e[i] = e1[i] + " and " + e2[i];
                    }
                    else
                        e[i] = e1[i];
                }
                return e;
        }
    }
}
