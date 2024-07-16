using System.ComponentModel;
using System;
using System.Xml.Linq;
using System.Reflection.Emit;

namespace Ass02OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01 : Try all what we have learned in the lecture.
            //Done in the Demo
            #endregion
            #region Part02 - Q1 : Define a struct &quot;Person&quot; with properties &quot;Name&quot; and &quot;Age&quot;. Create an array of three &quot; Person & quot; objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person P = new Person(3);
            //P.AddPerson(0, "Mohamed", 21);
            //P.AddPerson(1, "Ahmed", 21);
            //P.AddPerson(2, "Ali", 21);
            //for (int i = 0; i < P.Size; i++)
            //    Console.WriteLine(P[i]);
            #endregion
            #region Q2 : Create a struct called &quot;Person&quot; with properties &quot;Name&quot; and &quot;Age&quot;. Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Personn[] people = new Personn[3];
            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.Write($"Name {i + 1}: ");
            //    people[i].Name = Console.ReadLine();
            //    Console.Write($"Age {i + 1}: ");
            //    people[i].Age = Convert.ToInt32(Console.ReadLine());
            //}
            //int Old = 0;
            //for (int i = 1; i < people.Length; i++)
            //{
            //    if (people[i].Age > people[Old].Age)
            //    {
            //        Old = i;
            //    }
            //}
            //Console.WriteLine($"Name: {people[Old].Name}");
            //Console.WriteLine($"Age: {people[Old].Age}");
            #endregion
            #region Part03-Q6 : Design and implement a Class for the employees in a company:Employee is identified by an ID, Name, security level, salary, hire date and Gender.
            Employee[] employees = new Employee[3];
            employees[0] = Employee.CreateEmployee(SecurityPrivileges.DBA);
            employees[1] = Employee.CreateEmployee(SecurityPrivileges.Guest);
            employees[2] = Employee.CreateEmployee(SecurityPrivileges.DBA | SecurityPrivileges.Guest | SecurityPrivileges.Developer | SecurityPrivileges.Secretary);
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
            #endregion
        }
    }
}