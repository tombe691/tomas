using System;

namespace Assignment2A
{
    /// <summary>
    /// Input.cs
    /// 
    /// Created:    By: C# instructor, Sept 15th 2016
    /// Purpose:    This class contains shared (static) methods for reading integer and double
    ///             values from the console. All the methods provided by this class can be 
    ///             called directly by the class name Input.xxx.
    /// </summary>
    class Input
    {
        /// <summary>
        /// Writes a given message to the console and converts console input to integer. 
        /// If input cannot be converted to integer, an error message is printed on the console. 
        /// The process is repeated until conversion is succesful.
        /// </summary>
        /// <param name="messageToUser">The string to be printed on the console</param>
        /// <returns>The int value entered by the user</returns>
        public static int ReadIntegerConsole(string messageToUser)
        {
            // Declare value to return
            int convertedValue = 0;  //local variable must be initiated.

            //A flag to stop the loop
            bool goodNumber = false;

            // Loop until user input can be converted to integer
            do
            {
                // Display info message on console
                Console.Write(messageToUser);

                // Check if console input can be converted to integer 
                // goodNumber will be true if conversion is successful           
                goodNumber = int.TryParse(Console.ReadLine(), out convertedValue);

                if (!goodNumber)  //same as (goodNumber == false)
                    Console.WriteLine("Input must be an integer. Try again.");

                //If conversion was not succesful, continue with the loop
            } while (!goodNumber);  //means: while (done == false)

            //loop is finished and there is a good number - send it back.
            return convertedValue;
        }

    }
}
