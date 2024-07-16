using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {
        #region Prop
        public int Id { get; set; }
        public string? Model { get; set; }
        public double Speed { get; set; }
        #endregion
        public Car(int id, string? model, double speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
        }
        public Car(int id) : this(id, "Audi", 280)
        {
        }
        public Car()
        {

        }
        #region Constructors

        #endregion

        public override string ToString()
        {
            return $"CarId : {Id}\nModel : {Model}\nSpeed : {Speed}";
        }
    }

}
