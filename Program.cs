using System;

namespace Ref_vs_Vall_Passing
{
    public class Person {
        internal string FullName { get; set; }
    }

    class Program
    {
        private static void ChangeValue(int val)
        {
            val = val + 1;
            Console.WriteLine("Value while in the method: " + val);
        }

        private static void ChangeReference(Person pers)
        {
            pers.FullName = "Petar Petrovic";
            Console.WriteLine("Value while in the method: " + pers.FullName);
        }

        static void Main(string[] args)
        {
            // Value Type
            // =====================================================================
            int value = 1;

            Console.Write("Value before the changing method: {0}\n", value);
            
            ChangeValue(value);

            Console.Write("Value after the changing method: {0}\n\n", value);


            // Reference Type
            // =====================================================================
            Person person1 = new Person();
            person1.FullName = "Milan Vulin";

            Console.Write("My mane before the changing method: {0}\n", person1.FullName);

            ChangeReference(person1);

            Console.Write("My name after the changing method: {0}\n", person1.FullName);

        }
    }
}
