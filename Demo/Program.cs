﻿using Demo.Encapsulation;
using Demo.Inheritance;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation
            //Employee employee = new Employee(1,"Mohamed",3000 );
            //Employee employee = new Employee(name: "Mohamed", id: 2, salary: 3000);
            //employee.Id = 5;
            //Console.WriteLine(employee.Id);

            //employee.SetName("Mohamed");
            //Console.WriteLine(employee.GetName());

            //employee.Salary = 4000;
            //Console.WriteLine(employee.Salary);

            //Employee emp = new Employee(50, "Mohamed", 6000, 21);
            //Console.WriteLine(emp.Deduction); 
            #endregion
            #region Indexer
            //PhoneBook Note = new PhoneBook(3);
            //Note.AddPerson(0, "Mohamed", 2133);
            //Note.AddPerson(1, "Ali", 5215);
            //Note.AddPerson(2, "Omar", 863133);

            //int Num = Note.GetPersonNumber("Ali");
            //Console.WriteLine(Num == -1 ? "Not Found" : Num);

            //Note["Omar"] = 786;
            //Console.WriteLine(Note["Omar"]);

            //for (int i = 0; i < Note.Size; i++)
            //    Console.WriteLine(Note[i]);  
            #endregion
            #region Class
            //Car C1;
            //C1 = new Car();
            //Console.WriteLine(C1);
            //Car C2 = new Car(20, "Kia", 300);
            //Console.WriteLine(C2);
            #endregion
            #region Inheritance
            //Parent P = new Parent(2, 5);
            //Console.WriteLine(P);
            //Console.WriteLine(P.Product());
            //Console.WriteLine("____________________");
            //Child C = new Child(3, 2, 1);
            //Console.WriteLine(C);
            //Console.WriteLine(C.Product()); 
            #endregion

        }
    }
}
