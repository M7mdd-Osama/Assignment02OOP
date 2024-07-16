using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Child : Parent
    {

        //public int X { get; set; }
        //public int Y { get; set; }
        public int Z { get; set; }
        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
        public override string ToString()
        {
            return $"({X} , {Y} , {Z})";
        }
        public new int Product()
        {
            return base.Product() * Z;
        }

        //public int Product()
        //{
        //    return X * Y * Z;
        //}
        //public override string ToString()
        //{
        //    return $"{X},{Y},{Z}";
        //}
    }
}
