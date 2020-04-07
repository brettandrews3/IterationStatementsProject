using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //DONE Create a List called "numbers"
            var numbers = new List<int>();
            //DONE Create a variable of type int with an initializer of 0
            var init = 0;



            // Create a do-while loop
            do { init++;
                numbers.Add(init);
            {
                //DONE Increment your variable by 1
                //DONE Then add your variable to "numbers"
            }
                while (init < 100) ;
                //DONE While your variable is less than 100



                // Create a while loop
                // While your variable is less than 200
                while
            {
                    init < 200, init++;
                    numbers.Add(init);
                // Increment your variable by 1
                // DONE Then add your variable to "numbers"
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            // Write your variable to the console

            Console.WriteLine($"{init}");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            {
                // Write to the console "numbers" at index i
            }
        }
    }
}
