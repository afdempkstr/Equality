using System;

namespace Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1a = new Person("John");
            Person person1b = person1a;
            Person person2 = new Person(person1a.ToString());

            Console.WriteLine("person1a and person1b: {0}", person1a.Equals(person1b));
            Console.WriteLine($"person1a == person1b? {person1a == person1b}");
            Console.WriteLine("person1a and person2: {0}", person1a.Equals(person2));

            //Cast to an Object and call Equals
            Console.WriteLine("person1a and person1b: {0}", ((object)person1a).Equals((object)person1b));
            Console.WriteLine("person1a and person2: {0}", ((object)person1a).Equals((object)person2));

            Person empty = null;
            Person notEmpty = new Person("test");
            Console.WriteLine(empty == notEmpty);

            // If the current instance is a value type, the Equals(Object) method tests for value equality.
            // Value equality means that The two objects are of the same type.
            // the following example shows, a Byte object that has a value of 12 does not equal an Int32 object that has a value of 12, 
            // because the two objects have different run-time types.
            byte value1 = 12;
            int value2 = 12;

            Console.WriteLine(value1 == value2);

            object object1 = value1; //boxing
            object object2 = value2; //boxing

            Console.WriteLine("{0} ({1}) = {2} ({3}): {4}",
                              object1, object1.GetType().Name,
                              object2, object2.GetType().Name,
                              object1.Equals(object2));
            //beware of comparisons / equality checks between different types
        }
    }
}
