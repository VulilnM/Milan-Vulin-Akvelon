using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Implementation
{
    abstract class Animal
    {
        // Protected access modifiers for inheritance
        protected string animalType;
        protected string animalSubType;
        protected int numberOfLegs;
        protected string typeOfFur;

        // Constructor for encapsulation (and also abstraction?)
        public Animal(string AnimalType, string AnimalSubType, int NumberOfLegs, string TypeOfFur)
        {
            animalType = AnimalType;
            animalSubType = AnimalSubType;
            numberOfLegs = NumberOfLegs;
            typeOfFur = TypeOfFur;
        }

        // Overriding for polymorphysm
        protected abstract string makeSound();
        public abstract void presentSelf();
    }
}
