using System;

namespace Assignment2A
{
    class MainProgram
    /// <summary>
    /// MainProgram.cs
    /// 
    /// Created:    By: C# student Tomas Berggren, Feb 2nd 2019
    /// Purpose:    This class contains the call to the TemperatureConverter Class.
    /// </summary>

    {
        /// <summary>
        /// Main method starts the application and create and instance of the
        /// temperatureConverter class, then calls the Start method. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            TemperatureConverter temperatureConverter = new TemperatureConverter();
            temperatureConverter.Start();
        }
    }
}
