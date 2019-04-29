using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBCC_WMAD_Console
{
    /// <summary>
    /// Helper for output
    /// </summary>
    internal class Output
    {
        private Output() { }

        /// <summary>
        /// Print
        /// </summary>
        /// <param name="msg"></param>
        public static void P(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
