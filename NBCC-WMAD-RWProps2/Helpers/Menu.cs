using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBCC_WMAD_Console
{
    class Menu
    {
        /// <summary>
        /// Application Menu. Add items here to display to the user
        /// </summary>
        public static SortedList<int, string> menuDictionary = new SortedList<int, string>();

        /// <summary>
        /// Create the menu from items in menu sorted list
        /// </summary>
        /// <returns>The menu based on items created in the menu dictionary</returns>
        public static string CreateMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            StringBuilder sb = new StringBuilder();
            int longestLine = 0;

            foreach (KeyValuePair<int, string> item in Menu.menuDictionary.OrderBy(d => d.Key))
            {
                sb.Append(item.Key.ToString());
                sb.Append(": ");
                sb.Append(item.Value);
                sb.Append("\n");
                longestLine = (item.Value.Length + item.Key.ToString().Length + 2) > longestLine
                    ? longestLine = (item.Value.Length + item.Key.ToString().Length + 2)
                    : longestLine;
            }

            string border = new String('~', longestLine);
            sb.Insert(0, "Select a Menu Item\n\n");
            sb.Insert(0, "\n");
            sb.Insert(0, border);


            sb.Append(border);
            return sb.ToString();
        }

        /// <summary>
        /// The menu selection from the user
        /// </summary>
        public static string menuSelection;
    }
}
