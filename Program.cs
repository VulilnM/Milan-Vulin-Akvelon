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

            // Now when we know how the stack stores its numbers lets test out some of its methods
            // Peek vs Pop 

            // Peek - only returns the value, doesn't remove it from the stack 
            Console.WriteLine("Peeking the last element ");
            Console.WriteLine(myStack.Peek());
            Console.WriteLine("Stack after peek: ");
            foreach (int num in myStack)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");

            // Pop - returns and removes the value from the stack
            Console.WriteLine("Poping the last element ");
            Console.WriteLine(myStack.Pop());
            Console.WriteLine("Stack after pop: ");
            foreach (int num in myStack)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");

            // Now lets see if the stack contains user input number
            Console.WriteLine("Type in the number that you want to find in stack!");
            Console.Write("Number to find: ");
            int userNumber = Int32.Parse(Console.ReadLine());

            // Now that we have the number we' ll use Contains() method to see if it's in the stack
            Console.WriteLine("The stack" + (myStack.Contains(userNumber) ? " contains " : " does not contain ") + "the number {0}", userNumber);

        }
    }
}
