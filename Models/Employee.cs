using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Models
{
    class Employee
    {
        public int Id { get; set; } 
        public string FIO { get; set; }
        public string EmployeeNumber { get; set; }
        public string Male { get; set; }    
        public DateTime DateOfBirthday { get; set; }
        public int Passport { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public int Position { get; set; }
        public string Password { get; set; }
        public int Salary { get; set; }
    }
}
