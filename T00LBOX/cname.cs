using Pastel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CNAME
{
    public static  class cname
    {
        public static void cname2()
        {
            Console.Clear();
            Console.WriteLine($"\n{new string('▬', 120)}".Pastel("#ffffff"));
            Console.WriteLine($"COMPUTER NAME: " + $"{INFO.self_info.m_name()}".Pastel("#ff0000"));
            Console.WriteLine($"\n{self_console.oNumber(1)}CHANGE COMPUTER NAME");
            Console.WriteLine($"\n{self_console.oNumber(0)}Turn Back.");
            Console.WriteLine($"\n{new string('▬', 120)}".Pastel("#ffffff"));
            Console.Write("\nEnter A Number: ".Pastel("ff0000"));
            string c = Console.ReadLine();
            if (c == "0")
            {
                self_console.exit_choice(c);
            }
            else if (c == "1")
            {
                Console.Clear();
                Console.Write("Enter NEW Computer Name: ".Pastel("ff0000"));
                string newc = Console.ReadLine();
                try
                {
                    if (self_console.SetComputerNameEx(vars.CNPDH, newc))
                    {
                        Console.Clear();
                        Console.WriteLine("COMPUTER NAME CHANGED TO: ".Pastel("1dff00") + newc);
                        Console.WriteLine("\nRESTART REQUIRED, PRESS \"Y\" TO RESTART.".Pastel("ff0000"));
                        ConsoleKeyInfo r = Console.ReadKey();
                        if (r.KeyChar == 'Y' || r.KeyChar == 'y')
                        {
                            Process.Start("shutdown", "/r /t 0");
                        }
                        else
                        {
                            Console.WriteLine(r);
                            Console.ReadKey();
                            CONSOLESHOW.consoleShows.info();
                        }

                    }
                    else
                    {
                        int errorCode = Marshal.GetLastWin32Error();
                        Console.WriteLine("Failed to change computer name. Error code: ".Pastel("ff0000") + errorCode + "\nPRESS ENTER TO EXIT.");
                        Console.ReadLine();
                        CONSOLESHOW.consoleShows.info();
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("An error occurred: ".Pastel("ff0000") + ex.Message.Pastel("ffffff") + "\nPRESS ENTER TO EXIT.");
                    Console.ReadLine();
                    CONSOLESHOW.consoleShows.info();
                }
            }
            else
            {
                self_console.exit_choice(c);
            }
        }

    }
}
