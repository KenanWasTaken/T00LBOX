
//////////////////////////
//        SYSTEM D.     //
//////////////////////////

using Microsoft.Win32;
using Pastel;
using System;
using System.Diagnostics;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Buffers;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "T00LBOX | CREATED BY KENANWASTAKEN";
        IntPtr ptr = self_console.GetConsoleWindow();
        self_console.MoveWindow(ptr, self_screen.screenCenterX(), self_screen.screenCenterY(), vars.consoleW, vars.consoleH, true);
        self_consoleShows.creator();
        self_consoleShows.t00lbox();
        self_consoleShows.info();
    }
}

class vars
{
    public const int        CNPDH                      = 5;
    static public int       consoleW                    = 1000;
    static public int       consoleH                    = 1000;
    static public string    user                        = self_info.user();
    static public string    m_name                      = self_info.m_name();
    static public string    isInternet                  = self_info.isInternet("d");
    static public string    GetWindowsEdition           = self_info.GetWindowsEdition();
    static public string    GetWindowsVersion           = self_info.GetWindowsVersion();
    static public string    GetWindowsBuildVersion      = self_info.GetWindowsBuildVersion();
    static public string    GetWindowsArchitecture      = self_info.GetWindowsArchitecture();
    static public string    cpu                         = self_info.cpu();
    static public string    ram                         = self_info.ram().ToString();
    static public int       i_ram                       = self_info.ram();
    static public string    gpu                         = self_info.gpu(true);
    static public string    gpuD                        = self_info.gpu(false);
    static public string    users                       = self_info.userList();
}
class self_console
{
    [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool SetComputerNameEx(int NameType, string lpBuffer);
    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern IntPtr GetConsoleWindow();
    [DllImport("user32.dll", SetLastError = true)]
    internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
    public static string oNumber(int n) { return "[".Pastel("#0008ff") + $"{n.ToString()}".Pastel("#ff9700") + "] ".Pastel("#0008ff"); }
    public static void choice(string c)
    {
        switch (c)
        {
            case "1":
                choices.user1();
                break;
            case "2":
                choices.cname2();
                break;
        }
    }
    public static void exit_choice(string c)
    {
        switch(c)
        {
            case "0":
                self_consoleShows.t00lbox();
                self_consoleShows.info();
                break;
            default:
                Console.Clear();
                Console.WriteLine("No Choice Found. Turning Main Menu...".Pastel("#ff0000"));
                Thread.Sleep(1000);
                self_consoleShows.t00lbox();
                self_consoleShows.info();
                break;
        }
    }
}
class self_consoleShows
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
        } catch
        {
            MessageBox.Show("CAN'T START \"CREATOR\", Did U Compile creator in \"T00LBOX\\creator\\\"?", "WARNING...");
        }
    }
    public static void info()
    {
        Console.Clear();
        Console.WriteLine($"{new string('▬', 120)}".Pastel("#ffffff"));
        Console.Write    ($"{self_console.oNumber(1)}USER: " + $"{vars.user}".Pastel("#ff0000") + " | ".Pastel("#ff9e00"));
        Console.Write    ($"{self_console.oNumber(2)}COMPUTERNAME: " + $"{vars.m_name}".Pastel("#ff0000") + " | ".Pastel("#ff9e00"));
        Console.WriteLine($"{self_console.oNumber(3)}CONNECTION: " + $"{vars.isInternet}".Pastel("#ff0000"));
        Console.WriteLine($"{self_console.oNumber(4)}OS:   " + $" {vars.GetWindowsEdition} ".Pastel("#ffffff").PastelBg("#000fff") + $" {vars.GetWindowsVersion} ".Pastel("#000000").PastelBg("#f000ff") + $" {vars.GetWindowsBuildVersion} ".Pastel("#000000").PastelBg("#ff9700") + $" {vars.GetWindowsArchitecture} ".Pastel("#ffffff").PastelBg("#ff0000"));
        Console.WriteLine($"{self_console.oNumber(5)}CPU:  " + $"{vars.cpu}".Pastel("#ff0000"));
        Console.WriteLine($"{self_console.oNumber(6)}RAM:  " + $"{vars.ram}".Pastel("#ff0000") + $" ({Convert.ToInt32(god_i_hate_math.ConvertMegabytesToGigabytes(vars.i_ram))} GB)".Pastel("#ffffff"));
        Console.Write    ($"{self_console.oNumber(7)}GPU:  " + $"{vars.gpu}".Pastel("#ff0000"));
        Console.WriteLine($"\n{new string('▬', 120)}".Pastel("#ffffff"));
        Console.Write("\nEnter A Number: ".Pastel("ff0000"));
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
class self_info
{
    public static string user() { return Environment.UserName; }
    public static string m_name() { return Environment.MachineName; }
    public static int ram()
    {
        ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_ComputerSystem");
        ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
        ulong ramm = 0;
        foreach (ManagementObject obj in searcher.Get())
        {
            ulong totalMemory = Convert.ToUInt64(obj["TotalPhysicalMemory"]);
            ramm = totalMemory / (1024 * 1024);     
        }
        return (int)ramm;
    }
    public static string cpu()
    {
        ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_Processor");
        ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
        string cpuName = "";
        foreach (ManagementObject obj in searcher.Get())
        {
            cpuName = obj["Name"].ToString();
        }
        return cpuName;
    }
    public static string gpu(bool d)
    {
        string gpuDetailed = "";
        string gpu = "";
        using (var searcher = new ManagementObjectSearcher("select * from Win32_VideoController"))
        {
            foreach (ManagementObject obj in searcher.Get())
            {
                gpuDetailed += ("Name  -  " + obj["Name"] + "\n" + "\n");
                gpu = obj["Name"].ToString();
                gpuDetailed += ("DeviceID  -  " + obj["DeviceID"] + "\n");
                gpuDetailed += ("AdapterRAM  -  " + obj["AdapterRAM"] + "\n");
                gpuDetailed += ("AdapterDACType  -  " + obj["AdapterDACType"] + "\n");
                gpuDetailed += ("Monochrome  -  " + obj["Monochrome"] + "\n");
                gpuDetailed += ("InstalledDisplayDrivers  -  " + obj["InstalledDisplayDrivers"] + "\n");
                gpuDetailed += ("DriverVersion  -  " + obj["DriverVersion"] + "\n");
                gpuDetailed += ("VideoProcessor  -  " + obj["VideoProcessor"] + "\n");
                gpuDetailed += ("VideoArchitecture  -  " + obj["VideoArchitecture"] + "\n");
                gpuDetailed += ("VideoMemoryType  -  " + obj["VideoMemoryType"] + "\n");
            }
        }
        if(d)
        {
            return gpu;
        } else { return gpuDetailed; }
    }
    public static string isInternet(string ip)
    {
        bool pingable = false;
        Ping pinger = null;
        if (ip == "d")
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return "TRUE";
                }
            }
            catch
            {
                return "FALSE";
            }
        } else
        {
            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(ip);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {

            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }
            return pingable.ToString().ToUpper();
        }
    }
    public static string GetWindowsEdition()
    {
        string edition = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", "");
        return edition;
    }
    public static string GetWindowsVersion()
    {
        string version = Environment.OSVersion.Version.ToString();
        return version;
    }
    public static string GetWindowsBuildVersion()
    {
        string buildVersion = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentBuild", "");
        return buildVersion;
    }
    public static string GetWindowsArchitecture()
    {
        string architecture = Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit";
        return architecture;
    }
    public static string userList()
    {
        ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_UserAccount WHERE LocalAccount=True");
        string users = "";
        foreach (ManagementObject user in searcher.Get())
        {
            users += ($"User: ".Pastel("#9900ff") + $"{user["Name"]}\n".Pastel("#ff8800"));
        }
        return users;
    }
}
class choices
{
    //HOLY FUCK IM NOT DOIN DAT 😭
    public static void user1()
    {
        Console.Clear();
        Console.WriteLine($"\n{new string('▬', 120)}".Pastel("#ffffff"));
        Console.WriteLine($"CURRENT USER: " + $"{self_info.user()}".Pastel("#ff0000"));
        Console.WriteLine("\n-----".Pastel("#9900ff") + "USER LIST".Pastel("#00ff1a") + "-----".Pastel("#9900ff"));
        Console.Write(vars.users);
        Console.WriteLine("-------------------".Pastel("#9900ff"));
        Console.WriteLine($"\n{self_console.oNumber(0)}Turn Back.");
        Console.WriteLine($"\n{new string('▬', 120)}".Pastel("#ffffff"));
        Console.Write("\nEnter A Number: ".Pastel("ff0000"));
        string c =Console.ReadLine();
        self_console.exit_choice(c);
    }  
    public static void cname2()
    {
        Console.Clear();
        Console.WriteLine($"\n{new string('▬', 120)}".Pastel("#ffffff"));
        Console.WriteLine($"COMPUTER NAME: " + $"{self_info.m_name()}".Pastel("#ff0000"));
        Console.WriteLine($"\n{self_console.oNumber(1)}CHANGE COMPUTER NAME");
        Console.WriteLine($"\n{self_console.oNumber(0)}Turn Back.");
        Console.WriteLine($"\n{new string('▬', 120)}".Pastel("#ffffff"));
        Console.Write("\nEnter A Number: ".Pastel("ff0000"));
        string c = Console.ReadLine();
        if(c == "0")
        {
            self_console.exit_choice(c);
        } else if (c == "1")
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
                    if(r.KeyChar == 'Y' || r.KeyChar == 'y')
                    {
                        Process.Start("shutdown", "/r /t 0");
                    } else
                    {
                        Console.WriteLine(r);
                        Console.ReadKey();
                        self_consoleShows.info();
                    }

                }
                else
                {
                    int errorCode = Marshal.GetLastWin32Error();
                    Console.WriteLine("Failed to change computer name. Error code: ".Pastel("ff0000") + errorCode + "\nPRESS ENTER TO EXIT.");
                    Console.ReadLine();
                    self_consoleShows.info();
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("An error occurred: ".Pastel("ff0000") + ex.Message.Pastel("ffffff") + "\nPRESS ENTER TO EXIT.");
                Console.ReadLine();
                self_consoleShows.info();
            }
        } else
        {
            self_console.exit_choice(c);
        }
    }

}
class god_i_hate_math
{
    public static double ConvertMegabytesToGigabytes(int megabytes)
    {
        double gigabytes = megabytes / 1024.0; // 1 GB = 1024 MB
        return gigabytes;
    }
}