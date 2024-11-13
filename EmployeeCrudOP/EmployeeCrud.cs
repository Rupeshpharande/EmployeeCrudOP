using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrudOP
{
    public class EmployeeCrud
    {
        List<Employee> employees;
        public EmployeeCrud()
        {
            employees = new List<Employee>();//list is empty

        }

        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }
        public void updateEmployee(Employee emp)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id==emp.Id)
                {
                   employees[i].Name = emp.Name;
                    employees[i].Post=emp.Post;
                    break;

                }

            }
            
        }
        public void DeleteEmployee(int id)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id == id)
                {
                    employees.Remove(employees[i]);
                    break;
                }
            }
        }
        public List<Employee> Employeelist()
        {
            return employees;
        }

        public Employee GetEmployeeById(int id)
        {
            Employee e = new Employee();
            for (int i = 0;i<employees.Count;i++)
            {
                if(employees[i].Id==id)
                {
                    e.Id = employees[i].Id;
                    e.Name = employees[i].Name;
                    e.Post = employees[i].Post;
                    break;
                }
            }
            return e;
        }

    }
}
