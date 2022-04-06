using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Implementation
{
    class Chicken : Animal
    {
        string colorOfFeathers { get; set; }

        public Chicken(string ColorOfFeathers, string AnimalType, string AnimalSubType, int NumberOfLegs, string TypeOfFur)
            : base(AnimalType, AnimalSubType, NumberOfLegs, TypeOfFur)
        {
            this.colorOfFeathers = ColorOfFeathers;
        }

        protected override string makeSound()
        {
            return "COOKOO COOKOO COOKOO!";
        }

        public override void presentSelf()
        {
            Console.WriteLine("Animal type: " + animalType + "\n" +
                              "Animal subtype: " + animalSubType + "\n" +
                              "Number of legs: " + numberOfLegs + "\n" +
                              "Type of Fur: " + typeOfFur + "\n" +
                              "Feather colors: " + colorOfFeathers + "\n" +
                              "Sound: " + makeSound()
                               );
        }
    }
}
