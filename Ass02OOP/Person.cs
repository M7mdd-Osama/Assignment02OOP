using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass02OOP
{
    public struct Person
    {
        private string[] name { get; set; }
        private int[] age { get; set; }
        public int Size { get; }
        public Person(int size)
        {
            name = new string[size];
            age = new int[size];
            Size = size;
        }
        public void AddPerson(int Position, string PersonName, int PersonAge)
        {
            if (name is not null && age is not null)
            {
                if (Position < Size)
                {
                    name[Position] = PersonName;
                    age[Position] = PersonAge;
                }
            }
        }
        public override string ToString()
        {
            return $"{name} : {age}";
        }
        public string this[int index]
        {
            get
            {
                return $"{index} :: {name[index]} :: {age[index]}";
            }
        }

    }
}
