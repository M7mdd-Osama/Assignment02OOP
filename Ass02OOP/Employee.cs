using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass02OOP
{
    [Flags]
    public enum SecurityPrivileges : byte
    {
        Guest = 1, Developer = 2, Secretary = 4, DBA = 8
    }
    public enum Gender
    {
        M, F
    }
    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public SecurityPrivileges securityLevel { get; set; }
        public double salary { get; set; }
        public HireDate hireDate { get; set; }
        public Gender gender { get; set; }
        public Employee()
        {

        }
        public Employee(Employee _employee)
        {
            id = _employee.id;
            name = _employee.name;
            securityLevel = _employee.securityLevel;
            salary = _employee.salary;
            gender = _employee.gender;
            hireDate = new HireDate(_employee.hireDate);
        }
        public override string ToString()
        {
            return $"Id: {id} - Name: {name} - Security Level: {securityLevel} - Salary: {salary:c} - Hire Date: {hireDate} - Gender: {gender}";
        }
        public static Employee CreateEmployee(SecurityPrivileges security)
        {
            Employee employee = new Employee();
            employee.securityLevel = security;
            string? input;
            int id;

            do
            {
                Console.Write("ID: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out id));
            employee.id = id;

            Console.Write("Name: ");
            employee.name = Console.ReadLine();

            do
            {
                Console.Write("Salary: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out id));
            employee.salary = id;

            employee.hireDate = HireDate.CreateHiringDate();

            Gender G;
            do
            {
                Console.Write("Gender: ");
                input = Console.ReadLine();
            } while (!Enum.TryParse(input, out G));
            employee.gender = G;

            return employee;
        }
        public static Employee[] SortEmployees(Employee[] employees)
        {
            for (int i = 0; i < employees.Length - 1; i++)
            {
                int min_Index = i;
                for (int j = i + 1; j < employees.Length; j++)
                    if (HireDate.CompartHiringDate(employees[j].hireDate, employees[min_Index].hireDate))
                        min_Index = j;
                if (min_Index != i)
                {
                    Employee temp = new Employee(employees[min_Index]);
                    employees[min_Index] = new Employee(employees[i]);
                    employees[i] = temp;
                }
            }
            return employees;
        }
    }
}
