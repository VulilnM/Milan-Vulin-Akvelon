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
            Console.WriteLine("\n");
            
            // Now we will remove the middle 5 elements from the list and print the list again
            // For this we will need a Predicate Delegate

            int[] MiddleFiveElements() {
                int middleNum = 0;
                foreach (int num in numbers) { 
                    if (num == numbers.Count / 2 - 1)
                        middleNum = num;
                }

                int[] middle5 = { numbers[middleNum - 2], numbers[middleNum - 1], middleNum + 1 , numbers[middleNum + 1], numbers[middleNum + 2] };
                return middle5;    
            }

            int[] middle5nums = MiddleFiveElements();

            //Middle five nubers
            Console.WriteLine("Middle 5: ");
            foreach (int num in middle5nums)
            {
                if (middle5nums[middle5nums.Length - 1] != num)
                    Console.Write(num + ", ");
                else
                    Console.Write(num);
            }
            Console.WriteLine();


            //Now that we have the middle five numbers we can extract them from the List
            numbers.RemoveRange(middle5nums[0]-1, 5);
            Console.WriteLine("Removing middle 5 elements of the list...\n");

            //and print out the list again
            Console.WriteLine("And now the list looks like this:");
            foreach (int num in numbers)
            {
                if (numbers[numbers.Count - 1] != num)
                    Console.Write(num + ", ");
                else
                    Console.Write(num);
            }
            Console.WriteLine();


            // Ok, so now that we have played around a little bit with our list, lets add some user inputs activity
            // We shall provide a functionality where user can choose a number and a place to insert that number in our list

            // First, we will read the user inputs 
            Console.WriteLine("Specify the number that you want to add:");
            int userNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Now, specify the position at which you want to insert the number {0}", userNumber);
            int userIndex = Int32.Parse(Console.ReadLine());

            Console.Write("The number {0} will be placed at {1}th position\n", userNumber, userIndex);

            Console.WriteLine("Inserting {0} at index {1} ...", userNumber, userIndex);
            numbers.Insert(userIndex -1, userNumber);

            //Show the modified list
            foreach (int num in numbers)
            {
                if (numbers[numbers.Count - 1] != num)
                    Console.Write(num + ", ");
                else
                    Console.Write(num);
            }
            Console.WriteLine();
        }
    }
}
