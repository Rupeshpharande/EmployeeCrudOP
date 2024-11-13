using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrudOP
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Post { get; set; }

        public override string ToString()
        {
            return $"{Id} ,{Name} {Post}";
        }
    }
}
