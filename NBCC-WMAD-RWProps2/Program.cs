using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using In = NBCC_WMAD_Console.Input;
using Out = NBCC_WMAD_Console.Output;

namespace NBCC_WMAD_Console
{
    class Program
    {
        /// <summary>
        /// Menu Items are added here
        /// </summary>
        private static void LoadMenu()
        {
            Menu.menuDictionary.Add(0, "Exit");
            Menu.menuDictionary.Add(1, "About the Console");            
        }

        static void Main(string[] args)
        {
            string choice = Init();

            while (choice.ToLower() == "y")
            {
                switch (In.Get<int>(Menu.CreateMenu(), ConsoleColor.Yellow))
                {
                    case 0:
                        choice = "n";
                        break;
                    case 1:
                        AboutThisApp();
                        break;
                    //Add more options in the menu here
                }
            }

            Out.P("Press any key to exit.");
            Console.ReadLine();
        }
                
        #region [My Functionality]

        /*
         * My methods will be added here for executing functionality within the console
         */

        #endregion

        /// <summary>
        /// The About this App
        /// </summary>
        private static void AboutThisApp()
        {
            Out.P("\n");
            Out.P("This app is the Console Root Application. Build on it by providing new menu items and adding to the switch statement");
            Out.P("\n");
        }
        
        /// <summary>
        /// Initialize the Console
        /// </summary>
        /// <returns></returns>
        private static string Init()
        {
            LoadMenu();
            string choice = "y";
            Logo.CreateLogo("The Root App");
            return choice;
        }
    }
}
