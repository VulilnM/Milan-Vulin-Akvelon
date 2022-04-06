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
            Console.WriteLine();
            
            //Now, lets add some more numbers from an array and print it out 
            int[] arr = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            numbers.AddRange(arr);

            Console.WriteLine("Added a range of numbers from 11 to 20, and now the list looks like the following: ");
            foreach (int num in numbers)
            {
                if (numbers[numbers.Count - 1] != num)
                    Console.Write(num + ", ");
                else
                    Console.Write(num);
            }


        }
    }
}
