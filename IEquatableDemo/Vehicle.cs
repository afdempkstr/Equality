using System;

namespace IEquatableDemo
{
    class Vehicle : IEquatable<Vehicle>
    {
        public int Speed { get; protected set; }

        public string Name { get; protected set; }

        public Vehicle() { }

        public Vehicle(string name, int speed)
        {
            Speed = speed;
            Name = name;
        }

        public override bool Equals(object other)
        {
            if (other == null)
                return false;

            if (object.ReferenceEquals(this, other))
                return true;

            if (this.GetType() != other.GetType())
                return false;
            // this will work for the Vehicle class and its subclasses
            //if (!(other is Vehicle))
            //    return false;

            // the as keyword is like a cast that returns null if unsuccessful
            return this.Equals(other as Vehicle);
        }

        public bool Equals(Vehicle other)
        {
            if (other == null)
                return false;

            if (object.ReferenceEquals(this, other))
                return true;

            if (this.GetType() != other.GetType())
                return false;

            if (this.Name == other.Name && this.Speed.Equals(other.Speed))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {Name}@{Speed}km/h";
        }
    }
}
