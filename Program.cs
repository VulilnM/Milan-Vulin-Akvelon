using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare an empty que
            Queue<int> myQueue = new Queue<int>();

            // First we'll make an array with some numbers
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Now we'll print out the arr
            Console.WriteLine("Array members: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");

            // Fill the queue with values
            foreach (int num in arr)
                myQueue.Enqueue(num);

            // Let's see the result
            Console.WriteLine("Queue members: ");
            foreach (int num in myQueue)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");


        }
    }
}
