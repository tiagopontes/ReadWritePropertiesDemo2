using System;

namespace NBCC_WMAD_Console
{
    /// <summary>
    /// Helper for prompting and returning user input
    /// </summary>
    internal class Input
    {
        private Input() { }

        /// <summary>
        /// Get Type from console
        /// </summary>
        /// <typeparam name="T">The data type expected</typeparam>
        /// <param name="msg">Message to show the user</param>
        /// <param name="inputColour">Set colour displayed for user input. Defaults to white</param>
        /// <param name="inLine">Places the user input on the same line if set to true</param>
        /// <returns>return the next T</returns>
        public static T Get<T>(string msg, ConsoleColor inputColour = ConsoleColor.White, bool inLine = false)
        {
            T returnValue = default(T);
            bool isValid = false;
            
            if (!inLine) Console.WriteLine(msg); else Console.Write(msg);


            while (!isValid)
            {
                try
                {
                    Console.ForegroundColor = inputColour;
                    returnValue = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                    isValid = true;
                }
                catch (Exception)
                {
                    isValid = false;
                }
            }

            return returnValue;
        }

        /// <summary>
        /// Get integer from console input
        /// </summary>
        /// <param name="msg">Message to show the user</param>
        /// <returns>return the next int</returns>
        public static int GetInt(string msg)
        {
            Console.WriteLine(msg);
            int returnValue = 0;

            while (!Int32.TryParse(Console.ReadLine(), out returnValue))
            {
                Console.WriteLine(msg);
            }

            return returnValue;
        }

        /// <summary>
        /// Get double from the console input
        /// </summary>
        /// <param name="msg">Message to show the user</param>
        /// <returns></returns>
        public static double GetDouble(string msg)
        {
            Console.WriteLine(msg);
            double returnValue = 0;

            while (!double.TryParse(Console.ReadLine(), out returnValue))
            {
                Console.WriteLine(msg);
            }

            return returnValue;
        }

        /// <summary>
        /// Get the console string input from the user.
        /// </summary>
        /// <param name="msg">The Prompt message to the user</param>
        /// <returns>The return string</returns>
        public static string GetString(string msg, bool inLine = false)
        {
            if (!inLine) Console.Write(msg); else Console.WriteLine(msg);

            string returnValue = "";

            while (returnValue == "")
            {
                returnValue = Console.ReadLine();
            }

            return returnValue;
        }
    }
}
