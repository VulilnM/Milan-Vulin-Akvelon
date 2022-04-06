using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare an empty stack
            Stack<int> myStack = new Stack<int>();

            
            // First we'll make an array with some numbers
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Now we'll print out the arr
            Console.WriteLine("Array members: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");

            // Fill the stack with values
            foreach (int num in arr) 
                myStack.Push(num);

            // Let's see the result
            Console.WriteLine("Stack members: ");
            foreach (int num in myStack)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");


        }
    }
}
