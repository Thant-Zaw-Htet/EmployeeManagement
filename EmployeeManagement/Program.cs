using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Program 
    {
        static void Main(string[] args)
        {
           Program program = new Program();
           program.StartProgram();
        }

        public void StartProgram()
        {
            
            EmployeeService employeeService = new EmployeeService();
            Console.WriteLine("Welcome Employee Management System. \n (1) Show Employee List \n (2) Add New Employee \n (3) Search Employee");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Employee List");
                    employeeService.SelectAllEmployee();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Welcome new Employee");
                    employeeService.AddNewEmployee();
                    break;
                case 3:
                    Console.Clear();
                    employeeService.SearchById();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid Choice");
                    break;
            }
          
        }
    }
}
