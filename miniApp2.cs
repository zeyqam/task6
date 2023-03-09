using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini.app_department.Models
{
    internal class Department
    {
        private string _name;
        public string Name
        {
            get=>_name; set
            {
                if (!string.IsNullOrWhiteSpace(value.Trim(' ')))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("duzgun ad daxil et");
                }
            }
        }

        public string Surname { get; private set; }

        public Employee[] Employees;
        private string name;
        private double salary;

        public Department()
        {
            Employees = new Employee[0];
        }
        public void CreatEemployee()
        {
            
            
                Console.WriteLine("Employee Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Employee Surname: ");
                string Surname = Console.ReadLine();

                
                
                    Console.WriteLine("Employee Salary: ");
                    double salary = double.Parse(Console.ReadLine());
                
            
                
            Employee employee = new Employee()
            {
                Name = name,
                Surname = Surname,
                Salary = salary
            };
            Array.Resize(ref Employees,Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;
        }

       

        public void ShowEmployee()
        {
            foreach (Employee item in Employees)
            {
                Console.WriteLine($"name: {item.Name},surname:{item.Surname},salary:{item.Salary}");
            }
        }
         
            bool CheckSalary(int salary)
            {
                if (salary > 250)
                    return true; else return false;
            }
    }
 
}
       
              
        


    


