using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Employee
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }    
        public string Position { get; set; }
        public char Gender { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }

        public Employee()
        {
            
        }

        public Employee(Guid id,  string name, int age, string position, char gender, decimal salary, string address)
        {
            Id = id;
            Name = name;
            Age = age;
            Position = position;
            Gender = gender;
            Salary = salary;
            Address = address;
              
        }
    }
}
