using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encapsulation
{
    internal struct PhoneBook
    {
        #region Attributes
        private string[] Names;
        private int[] Numbers;
        #endregion
        #region Prop
        public int Size { get; } //ReadOnly Prop

        #endregion
        #region Ctor
        public PhoneBook(int size)
        {
            Names = new string[size];
            Numbers = new int[size];
            Size = size;
        }
        #endregion
        #region Methods
        public void AddPerson(int Position, string PersonName, int PhoneNumber) //object member func
        {
            if (Names is not null && Numbers is not null)
            {
                if (Position < Size)
                {
                    Names[Position] = PersonName;
                    Numbers[Position] = PhoneNumber;
                }
            }
        }
        #endregion
        #region Getter Setter
        public int GetPersonNumber(string PersonName)
        {
            if (Names is not null && Numbers is not null)
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    if (Names[i] == PersonName)
                        return Numbers[i];
                }
            }
            return -1;
        }
        public void SetPersonNumber(string personName, int NewNumber)
        {
            if (Names is not null && Numbers is not null)

                for (int i = 0; i < Names.Length; i++)

                    if (Names[i] == personName)
                    {
                        Numbers[i] = NewNumber;
                        break;
                    }
        } 
        #endregion
    }
}