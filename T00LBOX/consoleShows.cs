using Pastel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONSOLESHOW
{
    public static class consoleShows
    {
        public static void creator()
        {
            try
            {
                string executablePath = "..\\..\\creator\\creator\\bin\\Debug\\creator.exe";
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = executablePath;
                Process process = new Process();
                process.StartInfo = startInfo;
                process.Start();
            }
            catch
            {
                MessageBox.Show("CAN'T START \"CREATOR\", Did U Compile creator in \"T00LBOX\\creator\\\"?", "WARNING...");
            }
        }
        public static void info()
        {
            Console.Clear();
            Console.WriteLine($"{new string('▬', 120)}".Pastel("#ffffff"));
            Console.Write($"{self_console.oNumber(1)}USER: " + $"{vars.user}".Pastel("#ff0000") + " | ".Pastel("#ff9e00"));
            Console.Write($"{self_console.oNumber(2)}COMPUTERNAME: " + $"{vars.m_name}".Pastel("#ff0000") + " | ".Pastel("#ff9e00"));
            Console.WriteLine($"{self_console.oNumber(3)}CONNECTION: " + $"{vars.isInternet}".Pastel("#ff0000"));
            Console.WriteLine($"{self_console.oNumber(4)}OS:   " + $" {vars.GetWindowsEdition} ".Pastel("#ffffff").PastelBg("#000fff") + $" {vars.GetWindowsVersion} ".Pastel("#000000").PastelBg("#f000ff") + $" {vars.GetWindowsBuildVersion} ".Pastel("#000000").PastelBg("#ff9700") + $" {vars.GetWindowsArchitecture} ".Pastel("#ffffff").PastelBg("#ff0000"));
            Console.WriteLine($"{self_console.oNumber(5)}CPU:  " + $"{vars.cpu}".Pastel("#ff0000"));
            Console.WriteLine($"{self_console.oNumber(6)}RAM:  " + $"{vars.ram}".Pastel("#ff0000") + $" ({Convert.ToInt32(god_i_hate_math.MbToGb(vars.i_ram))} GB)".Pastel("#ffffff"));
            Console.Write($"{self_console.oNumber(7)}GPU:  " + $"{vars.gpu}".Pastel("#ff0000"));
            Console.WriteLine($"\n{new string('▬', 120)}".Pastel("#ffffff"));
            Console.Write("\nEnter A Number: ".Pastel("ff0000"));
            Console.SetCursorPosition(0, 58);
            Console.WriteLine($"v{vars.appversion}".Pastel("#000000").PastelBg("#ffffff"));
            Console.SetCursorPosition(93, 58);
            Console.WriteLine($" CREATED BY ".Pastel("#000000").PastelBg("#ffffff") + " KENANWASTAKEN ".Pastel("#ffffff").PastelBg("#ff0000"));
            Console.SetCursorPosition(16, 8);
            string choice = Console.ReadLine();
            self_console.choice(choice);
        }
        public static void t00lbox()
        {
            Console.Clear();
            Console.WriteLine("                                                                                             ".Pastel("#ffffff"));
            Console.WriteLine("             ░▒▓████████▓▒░▒▓████████▓▒░▒▓████████▓▒░▒▓█▓▒░      ░▒▓███████▓▒░ ░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░ ".Pastel("#ffffff"));
            Console.WriteLine("                ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ ".Pastel("#ffffff"));
            Console.WriteLine("                ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ ".Pastel("#ffffff"));
            Console.WriteLine("                ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓███████▓▒░░▒▓█▓▒░░▒▓█▓▒░░▒▓██████▓▒░  ".Pastel("#ffffff"));
            Console.WriteLine("                ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ ".Pastel("#ffffff"));
            Console.WriteLine("                ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ ".Pastel("#ffffff"));
            Console.WriteLine("                ░▒▓█▓▒░   ░▒▓████████▓▒░▒▓████████▓▒░▒▓████████▓▒░▒▓███████▓▒░ ░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░ \n".Pastel("#ffffff"));
            /*Console.Write("i hate you".Pastel("#ff0000"));
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(500);
                Console.Write(".".Pastel("#ff0000"));
            }
            Thread.Sleep(500);
            */
        }
        public static void t1tle(string text, int delay)
        {
            while (true)
            {
                for (int i = 1; i <= text.Length; i++)
                {
                    Console.Title = text.Substring(0, i);
                    Thread.Sleep(delay);
                }
                for (int i = text.Length; i >= 0; i--)
                {
                    Console.Title = text.Substring(0, i);
                    Thread.Sleep(delay);
                }
            }
        }
    }
}
