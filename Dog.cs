using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Implementation
{
    class Dog : Animal
    {
        bool willItBilte { get; set; }

        public Dog(bool WillItBilte, string AnimalType, string AnimalSubType, int NumberOfLegs, string TypeOfFur)
            : base(AnimalType, AnimalSubType, NumberOfLegs, TypeOfFur)
        {
            this.willItBilte = WillItBilte;
        }

        protected override string makeSound()
        {
            return "WUF WUF";
        }

        public override void presentSelf()
        {
            Console.WriteLine("Animal type: " + animalType + "\n" +
                              "Animal subtype: " + animalSubType + "\n" +
                              "Number of legs: " + numberOfLegs + "\n" +
                              "Type of Fur: " + typeOfFur + "\n" +
                              "Does he bite: " + willItBilte + "\n" +
                              "Sound: " + makeSound()
                               );
        }
    }
}
