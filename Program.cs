using System;

namespace OOP_Principles_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Presenting a very cute animal called Milica! :)");
            Cat milica = new Cat(2, "Mammel", "Cat", 4, "Hair");
            milica.presentSelf();
            Console.WriteLine();

            Console.WriteLine("Presenting a very dangerous animal called Dzeki! :)");
            Dog dzeki = new Dog(true, "Mammel", "Dog", 4, "Hair");
            dzeki.presentSelf();
            Console.WriteLine();

            Console.WriteLine("Presenting a very tasty animal called Kokoš Anel! x)");
            Chicken kokoshAnel = new Chicken("All kinds of nice, warm colors!", "Bird", "Chicken", 2, "Feathers");
            kokoshAnel.presentSelf();
            Console.WriteLine();
        }
    }
}
