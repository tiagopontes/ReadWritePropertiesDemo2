using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBCC_WMAD_Console
{
    class Logo
    {
        internal static void CreateLogo(string title)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("                             .,-:;//;:=,");
            Console.WriteLine("                         . :H@@@MM@M#H/.,+%;,");
            Console.WriteLine("                      ,/X+ +M@@M@MM%=,-%HMMM@X/,");
            Console.WriteLine("                    -+@MM; $M@@MH+-,;XMMMM@MMMM@+-");
            Console.WriteLine("                   ;@M@@M- XM@X;. -+XXXXXHHH@M@M#@/.");
            Console.WriteLine("                 ,%MM@@MH ,@%=             .---=-=:=,.");
            Console.WriteLine("                 =@#@@@MX.,                -%HX$$%%%:;");
            Console.WriteLine("                =-./@M@M$                   .;@MMMM@MM:");
            Console.WriteLine("                X@/ -$MM/                    . +MM@@@M$");
            Console.WriteLine("               ,@M@H: :@:                    . =X#@@@@-");
            Console.WriteLine("               ,@@@MMX, .                    /H- ;@M@M=");
            Console.WriteLine("               .H@@@@M@+,                    %MM+..%#$.");
            Console.WriteLine("                /MMMM@MMH/.                  XM@MH; =;");
            Console.WriteLine("                 /%+%$XHH@$=              , .H@@@@MX,");
            Console.WriteLine("                  .=--------.           -%H.,@@@@@MX,");
            Console.WriteLine("                  .%MM@@@HHHXX$$$%+- .:$MMX =M@@MM%.");
            Console.WriteLine("                    =XMMM@MM@MM#H;,-+HMM@M+ /MMMX=");
            Console.WriteLine("                      =%@M@M#@$-.=$@MM@@@M; %M%=");
            Console.WriteLine("                        ,:+$+-,/H#MMMMMMM@= =,");
            Console.WriteLine("                              =++%%%%+/:-.");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string border = new String('*', title.Length + 20);

            Console.WriteLine($"/{border}/");            
            Console.WriteLine($"          {title}          ");
            Console.WriteLine($"/{border}/");
        }
    }
}
