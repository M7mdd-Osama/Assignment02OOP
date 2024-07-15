using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encapsulation
{
    internal struct Employee
    {
        #region Attributes
        private int Id;
        private string? EmpName;
        private decimal Empsalary;
        #endregion
        #region Constructors
        public Employee(int id, string name, decimal salary, int age)
        {
            Id = id;
            EmpName = name;
            Salary = salary;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"{Id}\n{EmpName}\n{Empsalary:c}";
        }
        #endregion  
        #region Setter Getter
        public void SetName(string? value)
        {
            EmpName = value?.Length > 5 ? value.Substring(0, 5) : value;
        }
        public string? GetName()
        {
            return EmpName;
        }
        #endregion
        #region Property
        public decimal Salary
        {
            get { return Empsalary; }
            set { Empsalary = value < 6000 ? 6000 : value; }
        }
        public int Age { get; set; } //Automatic Prop
        public int age;

        public int Agee //Full Prop
        {
            get { return age; }
            set { age = value; }
        }
        //private decimal deduction; //Derived Attribute

        public decimal Deduction
        {
            get { return Salary * 0.2M; }
        }
        #endregion

    }
}
