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
        }
    }
}
