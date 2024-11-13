using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EmployeeCrudOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeCrud crud = new EmployeeCrud();

            try
            {

                int choice = 1;
                do {
                    Console.WriteLine("1.employee List");
                    Console.WriteLine("2.Add employee");
                    Console.WriteLine("3.Modify Employee");
                    Console.WriteLine("4.Delete Employee");
                    Console.WriteLine("5.Get employee by id");
                    Console.WriteLine("select 1 option");

                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            List<Employee> employees = crud.Employeelist();
                            Console.WriteLine("ID   Name   Post");
                            foreach (var items in employees)
                            {
                                Console.WriteLine(items);
                            }
                            break;


                        case 2:
                            Employee e = new Employee();
                            Console.WriteLine("Enter id:");
                            e.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name:");
                            e.Name = Console.ReadLine();
                            Console.WriteLine("Enter Post:");
                            e.Post = Console.ReadLine();
                            crud.AddEmployee(e);
                            Console.WriteLine("Employees added");
                            break;

                        case 3:
                            Employee e1 = new Employee();
                            Console.WriteLine("Enter id:");
                            e1.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name:");
                            e1.Name = Console.ReadLine();
                            Console.WriteLine("Enter Post");
                            e1.Post = Console.ReadLine();
                            crud.updateEmployee(e1);
                            Console.WriteLine("update employee");
                            break;


                        case 4:
                            Console.WriteLine("enter id:");
                            int id = Convert.ToInt32(Console.ReadLine());
                            crud.DeleteEmployee(id);
                            Console.WriteLine("Employee Delete");
                            break;

                        case 5:
                            Console.WriteLine("Enter id:");
                            int id1 = Convert.ToInt32(Console.ReadLine());
                            Employee ep=crud.GetEmployeeById(id1);
                            Console.WriteLine(ep);
                            break;


                    }

                    Console.WriteLine("Enter 1 for continue and 0 for exit");
                    choice = Convert.ToInt32(Console.ReadLine());
                } while (choice == 1);
            }catch(Exception e)
              {
                Console.WriteLine(e.Message);
              }

        }
    }
}
