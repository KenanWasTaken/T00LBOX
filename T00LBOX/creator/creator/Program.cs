using Pastel;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;


namespace creator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntPtr ptr = self_console.GetConsoleWindow();
            self_console.MoveWindow(ptr, self_screen.screenCenterX(), self_screen.screenCenterY() + 600, vars.consoleW, vars.consoleH, true);
            self_consoleShows.creator();
            Thread.Sleep(2000);
        }
    }

    class vars
    {
        static public int consoleW = 410;
        static public int consoleH = 80;
    }
    class self_console
    {
        public static void setColor(ConsoleColor c) { Console.ForegroundColor = c; }

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
    }
    class self_consoleShows
    {
        public static void creator()
        {
            string word = $" C R E A T E D  B Y  K E N A N W A S T A K E N ";
            string github = "            $github.com/kenanwastaken          ";
            string word2 = "";
            int cooldown = 20;
            foreach (char letter in word)
            {
                Console.Write(letter.ToString().Pastel("#FF0000"));
                if (letter.ToString() != " ") { word2 += letter; }
                Console.Title = word2;
                Thread.Sleep(cooldown);
            }
            foreach (char letter in github)
            {
                Console.Write(letter.ToString().Pastel("#FFA500"));
                Thread.Sleep(cooldown - 5);
            }
        }
    }
    class self_screen
    {
        public static int screenX()
        {
            Screen primaryScreen = Screen.PrimaryScreen;
            int screenWidth = primaryScreen.Bounds.Width;
            return screenWidth;
        }
        public static int screenY()
        {
            Screen primaryScreen = Screen.PrimaryScreen;
            int screenHeight = primaryScreen.Bounds.Height;
            return screenHeight;
        }

        public static int screenCenterX()
        {
            int consoleX = vars.consoleW;
            int con = ((screenX()) - consoleX) / 2;
            return con;
        }
        public static int screenCenterY()
        {
            int consoleY = vars.consoleH;
            int con = ((screenY()) - consoleY) / 2;
            return con;
        }
    }
}
