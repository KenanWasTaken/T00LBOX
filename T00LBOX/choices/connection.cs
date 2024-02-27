using Pastel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CONNECTION
{
    public static class connection
    {
        public static void connection3()
        {
            string google = "";
            string cloudflare = "";
            string controld = "";
            string quad9 = "";
            string animG = "";
            string animC = "";
            string anim9 = "";
            string animD = "";
            string animation = "-/|\\";
            int animationLength = animation.Length;
            int delay = 200;

            Thread googleDNStest = new Thread(INFO.self_info.googleDNS);
            Thread cloudflareDNStest = new Thread(INFO.self_info.cloudflareDNS);
            Thread controldDNStest = new Thread(INFO.self_info.controldDNS);
            Thread quad9DNStest = new Thread(INFO.self_info.quad9DNS);

            cloudflareDNStest.Start();
            controldDNStest.Start();
            quad9DNStest.Start();
            googleDNStest.Start();
            Console.Clear();
            Console.WriteLine($"{new string('▬', 120)}".Pastel("#ffffff"));
            Console.WriteLine("GOOGLE: ".Pastel("c500ff"));
            Console.WriteLine("CLOUDFLARE: ".Pastel("c500ff"));
            Console.WriteLine("CONTROLD: ".Pastel("c500ff"));
            Console.WriteLine("QUAD9: ".Pastel("c500ff"));
            Console.WriteLine($"{new string('▬', 120)}".Pastel("#ffffff"));
            while (true)
            {
                if (vars.connection_GOOGLE == "TRUE")
                {
                    google = vars.ms_GOOGLEDNS.ToString().Pastel("1dff00"); googleDNStest.Abort();
                }
                else if (vars.connection_GOOGLE == "TIMEOUT")
                {
                    google = "TIMED OUT!".Pastel("ff0000"); googleDNStest.Abort();
                }
                else if (vars.connection_GOOGLE == "FALSE")
                {
                    google = "FAILED".Pastel("ff0000"); googleDNStest.Abort();
                }

                if (vars.connection_CLOUDFLARE == "TRUE")
                {
                    cloudflare = vars.ms_CLOUDFLARE.ToString().Pastel("1dff00"); cloudflareDNStest.Abort();
                }
                else if (vars.connection_CLOUDFLARE == "TIMEOUT")
                {
                    cloudflare = "TIMED OUT!".Pastel("ff0000"); cloudflareDNStest.Abort();
                }
                else if (vars.connection_CLOUDFLARE == "FALSE")
                {
                    cloudflare = "FAILED".Pastel("ff0000"); cloudflareDNStest.Abort();
                }

                if (vars.connection_QUAD9 == "TRUE")
                {
                    quad9 = vars.ms_QUAD9.ToString().Pastel("1dff00"); quad9DNStest.Abort();
                }
                else if (vars.connection_QUAD9 == "TIMEOUT")
                {
                    quad9 = "TIMED OUT!".Pastel("ff0000"); quad9DNStest.Abort();
                }
                else if (vars.connection_QUAD9 == "FALSE")
                {
                    quad9 = "FAILED".Pastel("ff0000"); quad9DNStest.Abort();
                }

                if (vars.connection_CONTROLD == "TRUE")
                {
                    controld = vars.ms_CONTROLDDNS.ToString().Pastel("1dff00"); controldDNStest.Abort();
                }
                else if (vars.connection_CONTROLD == "TIMEOUT")
                {
                    controld = "TIMED OUT!".Pastel("ff0000"); controldDNStest.Abort();
                }
                else if (vars.connection_CONTROLD == "FALSE")
                {
                    controld = "FAILED".Pastel("ff0000"); controldDNStest.Abort();
                }
                if (google != "" && cloudflare != "" && controld != "" && quad9 != "")
                {
                    break;
                }
                else
                {
                    for (int i = 0; i < animationLength; i++)
                    {
                        if (google == "")
                        {
                            animG = ("" + animation[i]);
                        }
                        else
                        {
                            animG = google;
                        }
                        if (cloudflare == "")
                        {
                            animC = ("" + animation[i]);
                        }
                        else
                        {
                            animC = cloudflare;
                        }
                        if (controld == "")
                        {
                            animD = ("" + animation[i]);
                        }
                        else
                        {
                            animD = controld;
                        }
                        if (quad9 == "")
                        {
                            anim9 = ("" + animation[i]);
                        }
                        else
                        {
                            anim9 = quad9;
                        }
                        Console.SetCursorPosition(8, 1); Console.Write(animG);
                        Console.SetCursorPosition(12, 2); Console.Write(animC);
                        Console.SetCursorPosition(10, 3); Console.Write(animD);
                        Console.SetCursorPosition(7, 4); Console.Write(anim9);
                        Thread.Sleep(delay);
                    }
                    /*if (google != "" && cloudflare != "" && controld != "" && quad9 != "")
                    {
                        break;
                    }*/
                }
            }
            Console.Clear();
            Console.WriteLine($"{new string('▬', 120)}\n".Pastel("#ffffff"));
            Console.WriteLine("-----CHECK CONNECTION-----".Pastel("#ffffff"));
            Console.WriteLine("GOOGLE: ".Pastel("c500ff") + google);
            Console.WriteLine("CLOUDFLARE: ".Pastel("c500ff") + cloudflare);
            Console.WriteLine("CONTROLD: ".Pastel("c500ff") + controld);
            Console.WriteLine("QUAD9: ".Pastel("c500ff") + quad9);
            Console.WriteLine($"\n{self_console.oNumber(1)}" + "Try Again.".Pastel("#f58142"));
            Console.WriteLine("--------------------------".Pastel("#ffffff"));
            Console.WriteLine($"\n{self_console.oNumber(2)}" + INFO.self_info.GetSsid().Pastel("#ff0000") + " Settings.");
            Console.WriteLine($"{self_console.oNumber(3)}" + "Reset Internet Adapters.".Pastel("#ff0000"));
            Console.WriteLine($"{self_console.oNumber(4)}" + "Modify-Randomize MAC Address".Pastel("#ff0000"));
            Console.WriteLine($"\n{self_console.oNumber(0)}" + "Turn Back.".Pastel("#ff0000"));
            Console.WriteLine($"\n{new string('▬', 120)}".Pastel("#ffffff"));
            Console.Write("\nEnter A Number: ".Pastel("ff0000"));
            string c = Console.ReadLine();
            if (c == "1")
            {
                google = "";
                quad9 = "";
                controld = "";
                cloudflare = "";
                vars.ms_GOOGLEDNS = 1;
                vars.ms_CLOUDFLARE = 1;
                vars.ms_CONTROLDDNS = 1;
                vars.ms_QUAD9 = 1;
                vars.connection_GOOGLE = "NULL";
                vars.connection_CLOUDFLARE = "NULL";
                vars.connection_CONTROLD = "NULL";
                vars.connection_QUAD9 = "NULL";
                connection3();
            }
            if (c == "2")
            {
                connection_wifi();
            }
            if (c == "3")
            {
                Console.Clear();
                Console.WriteLine("Are Sure? This Will Require Reset. (y/n)".Pastel("#ff0000"));

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    self_console.internetreset();
                    Console.Clear();
                    Console.WriteLine("All Good. Do You Want To Reset Computer?");
                    ConsoleKeyInfo keyInfo2 = Console.ReadKey(true);
                    if (keyInfo2.Key == ConsoleKey.Y)
                    {
                        self_console.pc_restart();
                    }
                    else if (keyInfo2.Key == ConsoleKey.N)
                    {
                        Console.WriteLine("Canceled.".Pastel("ff0000"));
                        Thread.Sleep(1000);
                        connection3();
                    }
                    else
                    {
                        Console.WriteLine("Aborted.".Pastel("ff0000"));
                        Thread.Sleep(1000);
                        connection3();
                    }
                }
                else if (keyInfo.Key == ConsoleKey.N)
                {
                    Console.Clear();
                    Console.WriteLine("Canceled.".Pastel("ff0000"));
                    Thread.Sleep(1000);
                    connection3();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Aborted.".Pastel("ff0000"));
                    Thread.Sleep(1000);
                    connection3();
                }
            }
            if (c == "4")
            {
                Console.Clear();
                Console.WriteLine($"{self_console.oNumber(1)}" + "Modify Address MAC Address".Pastel("#ff0000"));
                Console.WriteLine($"{self_console.oNumber(2)}" + "Randomize MAC Address".Pastel("#ff0000"));
                Console.WriteLine($"\n{self_console.oNumber(0)}" + "Turn Back.".Pastel("#ff0000"));
                string selectedAdapter = "";
                Console.Write("\nEnter A Number: ".Pastel("ff0000"));
                string c2 = Console.ReadLine();
                if (c2 == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Available Network Adapters: \n".Pastel("#00ff59"));
                    for (int i = 0; i < vars.adapters.Count; i++)
                    {
                        Console.WriteLine($"{self_console.oNumber(i + 1)}" + $"{vars.adapters[i]}".Pastel("#6a00ff"));
                    }
                    Console.Write("\nEnter the number of the adapter you want to select: ".Pastel("#ff8c00"));
                    int selectedIndex;
                    if (int.TryParse(Console.ReadLine(), out selectedIndex) && selectedIndex > 0 && selectedIndex <= vars.adapters.Count)
                    {
                        selectedAdapter = vars.adapters[selectedIndex - 1];
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.ReadLine();
                    }
                    Console.Clear();
                    Console.WriteLine("MAC ADDRESS FORMAT: ".Pastel("#5c5c5c") + "XX-XX-XX-XX-XX-XX\n".Pastel("#ff0000"));
                    Console.Write("Type NEW MAC Address: ".Pastel("#ffc800"));
                    string newmac = Console.ReadLine();

                }
            }
            if (c == "0")
            {
                CONSOLESHOW.consoleShows.info();
            }

        }
        public static void connection_wifi()
        {
            Console.Clear();
            CONSOLESHOW.consoleShows.t00lbox();
            string ssid = INFO.self_info.GetSsid().Pastel("ffffff");
            string passwd = INFO.self_info.getWifiPasswd(INFO.self_info.GetSsid()).Pastel("ffffff");
            Console.Clear();
            Console.WriteLine($"{new string('▬', 120)}".Pastel("#ffffff"));
            Console.WriteLine("SSID:        ".Pastel("c500ff") + ssid);
            Console.WriteLine("Password:    ".Pastel("c500ff") + passwd);
            Console.WriteLine($"\n{self_console.oNumber(0)}" + "Turn Back.".Pastel("#ff0000"));
            Console.WriteLine($"{new string('▬', 120)}\n".Pastel("#ffffff"));
            Console.Write("\nEnter A Number: ".Pastel("ff0000"));
            string c = Console.ReadLine();
            if (c == "0")
            {
                connection3();
            }
        }
    }
}
