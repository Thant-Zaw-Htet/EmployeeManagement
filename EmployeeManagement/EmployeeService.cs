using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class EmployeeService : ManageEmployee
    {
        static List<Employee> employeDataList = new List<Employee>();
        Program program = new Program();
        public void SelectAllEmployee()
        {
            foreach (Employee emp in employeDataList)
            {
                Console.WriteLine($"Employee ID: {emp.Id} \n Employee Name: {emp.Name} \n Employee position: {emp.Position} \n Employee Salary: {emp.Salary} \n Employee gender: {emp.Gender} \n Employee age: {emp.Age} \n Employee address: {emp.Address}");

            }
            Console.WriteLine("Would you like to go main menu? (yes/no) \n");
            
            string menu = Console.ReadLine();
            if (menu.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                program.StartProgram();

            }
            else if (menu.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                SelectAllEmployee();
            }
        }
        public void AddNewEmployee()
        {
          
            while (true)
            {
                Console.WriteLine("Enter 'exit' to return to Main Menu.");
            
                Console.WriteLine("Enter employee name: ");
                string name = Console.ReadLine();
                if (name.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    program.StartProgram();
                }

           
                Console.WriteLine("Enter employee age: ");
                string age = Console.ReadLine();
                if (age.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    program.StartProgram();
                }
        
                Console.WriteLine("Enter employee address: ");
                string address = Console.ReadLine();
                if (address.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    program.StartProgram();
                }

          
                Console.WriteLine("Enter employee position: ");
                string position = Console.ReadLine();
                if (position.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    program.StartProgram();
                }

      
                Console.WriteLine("Enter gender (M/F): ");
                string gender = Console.ReadLine();
                if (gender.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    program.StartProgram();
                }

            
                Console.WriteLine("Enter employee salary: ");
                string salary = Console.ReadLine();
                if (salary.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    program.StartProgram();
                }

                
                if (string.IsNullOrEmpty(name) ||
                    string.IsNullOrEmpty(address) ||
                    string.IsNullOrEmpty(position) ||
                    !int.TryParse(age, out int ageInput) ||
                    !(gender.Equals("M", StringComparison.OrdinalIgnoreCase) || gender.Equals("F", StringComparison.OrdinalIgnoreCase)) ||
                    !decimal.TryParse(salary, out decimal salaryInput))
                {
                    Console.WriteLine("Please fill all data properly.");
                }
                else
                {
                 
                    Employee employee = new Employee
                    {
                        Id = Guid.NewGuid(),
                        Name = name,
                        Address = address,
                        Age = ageInput,
                        Position = position,
                        Gender = char.ToUpper(gender[0]),  
                        Salary = salaryInput
                    };

                    employeDataList.Add(employee);
                    Console.WriteLine("Employee added successfully.");
                }

        
                Console.WriteLine("Would you like to add another employee? (yes/no) \n");
                string addMore = Console.ReadLine();
                if (addMore.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    AddNewEmployee();
                }
                else if (addMore.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    program.StartProgram();
                }
                break;
            }
        }
        public void SearchById()
        {
            Console.WriteLine("Enter Employee ID: ");
            string employeeIdInput = Console.ReadLine();
         
            while (true)
            {                
              if (Guid.TryParse(employeeIdInput, out Guid employeeId))

                  {         
                    var employeeSearchList = employeDataList.Where(e => e.Id == employeeId);

                    foreach (var employee in employeeSearchList)

                       {
                         Console.WriteLine(employee.Name);
                         Console.WriteLine(employee.Address);
                         Console.WriteLine(employee.Age);
                         Console.WriteLine(employee.Gender);
                         Console.WriteLine(employee.Salary);
                         Console.WriteLine(employee.Position);
                       }
                    }
                    else
                    {
                        Console.WriteLine("Can't find Employee");
                }


                Console.WriteLine("Would you like to add another employee? (yes/no) \n");
                string addMore = Console.ReadLine();
                if (addMore.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    program.StartProgram();
                }
                else if (addMore.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    SearchById();
                }

            }
           
        }

    }
}

