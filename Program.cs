using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a list with numbers 1 through 10 
            List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10 };

            //Print the list
            Console.WriteLine("List contains following numbers:");
            foreach (int num in numbers) {
                //If it is the last element of the list - dont print the comma
                if (numbers[numbers.Count - 1] != num)
                    Console.Write(num + ", ");
                else
                    Console.Write(num);
            }
        }
    }
}
