using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Implementation
{
    class Cat : Animal
    {
        int lengthOfClaws { get; set; }

        public Cat(int lengthOfClaws, string AnimalType, string AnimalSubType, int NumberOfLegs, string TypeOfFur)
            : base(AnimalType, AnimalSubType, NumberOfLegs, TypeOfFur)
        {    
            this.lengthOfClaws = lengthOfClaws;
        }

        protected override string makeSound()
        {
            return "MEOW!";
        }

        public override void presentSelf()
        {
            Console.WriteLine("Animal type: " + animalType + "\n" +
                              "Animal subtype: " + animalSubType + "\n" +
                              "Number of legs: " + numberOfLegs + "\n" +
                              "Type of Fur: " + typeOfFur + "\n" +
                              "Length of claws: " + lengthOfClaws + "\n" +
                              "Sound: " + makeSound()
                               );
        }
    }
}
