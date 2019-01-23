using System;

namespace Array_InClass
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Taking user input
                Console.WriteLine("Please enter a number");
                string input1 = Console.ReadLine(); // reading user input
                int number = int.Parse(input1); // parsing user input
                Console.WriteLine("The value that user entered is " + number);

                // if statement if number between 0 and 10
                if (number > 0 && number <= 10)
                {
                    Console.WriteLine("Manually populated array");
                    int[] phone_array = { 8, 1, 3, 4, 5, 1, 4, 2, 0, 9 };                    

                    // foreach loop is for arrays
                    foreach( int i in phone_array)
                    {
                        Console.Write(i + " ");
                    } // end of foreach loop

                } // end of if (number > 0 && number <= 10)

                // else if statement when the number is between 10 and 20
                else if ( number > 10 && number <= 20)
                {
                    Console.WriteLine("Auto ppopulate the array");
                    int[] countdown = new int[number]; // declare an integer aaray of size "number"
                    int populate_array = 0; // initializing a vaiable to populate array

                    // for loop starts
                    for (int i = 0; i < number; i++)
                    {
                        countdown[i] = populate_array;
                        Console.Write(i + " ");
                    } // end of for loop


                } // end of else if ( number > 10 && number <= 20)

                else
                {
                    Console.WriteLine("Please enter an integer between 0 and 20");
                } // end of else

                // exit statement
                Console.WriteLine("\nPress any key to exit");
                Console.ReadKey(true);

            } // end of try
            
            // If error occurs in try block, this block is executed else it is not executed
            catch
            {
                Console.WriteLine("\nPlease enter valid input next time");
                Console.WriteLine("\nPress any key to exit");
                Console.ReadKey(true);
            } // end of catch 
            
        } // end of main
    } // end of class
} // end of namespace
