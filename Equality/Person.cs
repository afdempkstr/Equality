namespace Equality
{
    public class Person
    {
        private string personName;

        public Person(string name)
        {
            this.personName = name;
        }

        public override string ToString()
        {
            return this.personName;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            //obj.personName is accesible although it is private because we are
            //accessing it from within the same class
            return this.personName.Equals(((Person)obj).personName);
        }

        // == operator overloading
        public static bool operator ==(Person person1, Person person2)
        {
            if (person1 == null && person2 == null)
            {
                return true;
            }

            if(person1 != null)
            {
                return person1.Equals(person2);
            }
            return false;
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }
    }
}
