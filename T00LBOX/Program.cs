
//////////////////////////
//        SYSTEM D.     //
//////////////////////////

using Microsoft.Win32;
using Pastel;
using System;
using System.Diagnostics;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        Thread animationThread = new Thread(() => self_consoleShows.t1tle("                                                                                                                  T00LBOX | CREATED BY KENANWASTAKEN                                                                       ", 10));
        animationThread.Start();
        IntPtr ptr = self_console.GetConsoleWindow();
        self_console.MoveWindow(ptr, self_screen.screenCenterX(), self_screen.screenCenterY(), vars.consoleW, vars.consoleH, true);
        self_consoleShows.creator();
        self_consoleShows.t00lbox();
        self_consoleShows.info();

    }
}

class vars
{
    //APP
    static public string appversion = "0.2.2";

    static public int cursorx = Console.CursorLeft;
    static public int cursory = Console.CursorTop;
    public const int CNPDH = 5;
    static public int ping_times = 1;
    static public string ip_GOOGLEDNS = "8.8.8.8";
    static public string ip_CLOUDFLAREDNS = "1.1.1.1";
    static public string ip_CONTROLDDNS = "76.76.2.0";
    static public string ip_QUAD9 = "9.9.9.9";
    static public double ms_GOOGLEDNS = 1;
    static public double ms_CLOUDFLARE = 1;
    static public double ms_CONTROLDDNS = 1;
    static public double ms_QUAD9 = 1;
    static public string connection_GOOGLE = "NULL";
    static public string connection_CLOUDFLARE = "NULL";
    static public string connection_CONTROLD = "NULL";
    static public string connection_QUAD9 = "NULL";
    static public int consoleW = 1000;
    static public int consoleH = 1000;
    static public string user = self_info.user();
    static public string m_name = self_info.m_name();
    static public string isInternet = self_info.isInternet("d");
    static public string GetWindowsEdition = self_info.GetWindowsEdition();
    static public string GetWindowsVersion = self_info.GetWindowsVersion();
    static public string GetWindowsBuildVersion = self_info.GetWindowsBuildVersion();
    static public string GetWindowsArchitecture = self_info.GetWindowsArchitecture();
    static public string cpu = self_info.cpu();
    static public string ram = self_info.ram().ToString();
    static public int i_ram = self_info.ram();
    static public string gpu = self_info.gpu(true);
    static public string gpuD = self_info.gpu(false);
    static public string users = self_info.userList();
    static public string manufacturer = self_info.GetManufacturer();
    static public string installdate = self_info.GetInstallDate();
    static public string reguser = self_info.GetRegUser();
    static public string serialnumber = self_info.GetSerialNumber();
    static public string sysdir = self_info.GetSysDir();
    static public string bootdevice = self_info.GetBootDevice();
    static public string countrycode = self_info.GetCCode();
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
            case "3":
                choices.connection3();
                break;
            case "4":
                choices.os4();
                break;
        }
    }
    public static void exit_choice(string c)
    {
        switch (c)
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
        if (d)
        {
            return gpu;
        }
        else { return gpuDetailed; }
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
        }
        else
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
        string w = "";
        try
        {
            ManagementObjectSearcher searcher =
            new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                w = (string)os["Caption"];
            }
        } catch (Exception e)
        {
            w = "ERROR!";
        }
        return w;
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
    public static string GetManufacturer()
    {
        string w = "";
        try
        {
            ManagementObjectSearcher searcher =
            new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                w = (string)os["Manufacturer"];
            }
        }
        catch (Exception e)
        {
            w = "ERROR!";
        }
        return w;
    }
    public static string GetInstallDate()
    {
        string w = "";
        try
        {
            ManagementObjectSearcher searcher =
            new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                string installDate = os["InstallDate"].ToString();
                DateTime parsedInstallDate = ManagementDateTimeConverter.ToDateTime(installDate);
                w = (string)parsedInstallDate.ToString();
            }
        }
        catch (Exception e)
        {
            w = "ERROR!";
        }
        return w;
    }
    public static string GetRegUser()
    {
        string w = "";
        try
        {
            ManagementObjectSearcher searcher =
            new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                w = (string)os["RegisteredUser"];
            }
        }
        catch (Exception e)
        {
            w = "ERROR!";
        }
        return w;
    }
    public static string GetSerialNumber()
    {
        string w = "";
        try
        {
            ManagementObjectSearcher searcher =
            new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                w = (string)os["SerialNumber"];
            }
        }
        catch (Exception e)
        {
            w = "ERROR!";
        }
        return w;
    }
    public static string GetSysDir()
    {
        string w = "";
        try
        {
            ManagementObjectSearcher searcher =
            new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                w = (string)os["SerialNumber"];
            }
        }
        catch (Exception e)
        {
            w = "ERROR!";
        }
        return w;
    }
    public static string GetBootDevice()
    {
        string w = "";
        try
        {
            ManagementObjectSearcher searcher =
            new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                w = (string)os["BootDevice"];
            }
        }
        catch (Exception e)
        {
            w = "ERROR!";
        }
        return w;
    }
    public static string GetCCode()
    {
        string w = "";
        try
        {
            ManagementObjectSearcher searcher =
            new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                w = (string)os["CountryCode"];
            }
        }
        catch (Exception e)
        {
            w = "ERROR!";
        }
        return w;
    }
    public static string LastBoot()
    {
        string w = "";
        try
        {
            ManagementObjectSearcher searcher =
            new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                w = ManagementDateTimeConverter.ToDateTime(os["LastBootUpTime"].ToString()).ToString();
            }
        }
        catch (Exception e)
        {
            w = "ERROR!";
        }
        return w;
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
    public static void googleDNS()
    {
        string host = vars.ip_GOOGLEDNS;
        for (int i = 0; i < vars.ping_times + 1; i++)
        {
            try
            {
                Ping pingSender = new Ping();
                PingReply reply = pingSender.Send(host);

                if (reply.Status == IPStatus.Success)
                {
                    vars.ms_GOOGLEDNS = reply.RoundtripTime;
                    vars.connection_GOOGLE = "TRUE";
                    break;
                }
                else
                {
                    vars.connection_GOOGLE = "FALSE";
                }
            }
            catch (PingException)
            {
                vars.connection_GOOGLE = "TIMEOUT";
            }
        }
    }
    public static void cloudflareDNS()
    {
        string host = vars.ip_CLOUDFLAREDNS;
        for (int i = 0; i < vars.ping_times + 1; i++)
        {
            try
            {
                Ping pingSender = new Ping();
                PingReply reply = pingSender.Send(host);

                if (reply.Status == IPStatus.Success)
                {
                    vars.ms_CLOUDFLARE = reply.RoundtripTime;
                    vars.connection_CLOUDFLARE = "TRUE";
                    break;
                }
                else
                {
                    vars.connection_CLOUDFLARE = "FALSE";
                }
            }
            catch (PingException)
            {
                vars.connection_CLOUDFLARE = "TIMEOUT";
            }
        }
    }
    public static void quad9DNS()
    {
        string host = vars.ip_QUAD9;
        for (int i = 0; i < vars.ping_times + 1; i++)
        {
            try
            {
                Ping pingSender = new Ping();
                PingReply reply = pingSender.Send(host);

                if (reply.Status == IPStatus.Success)
                {
                    vars.ms_QUAD9 = reply.RoundtripTime;
                    vars.connection_QUAD9 = "TRUE";
                    break;
                }
                else
                {
                    vars.connection_QUAD9 = "FALSE";
                }
            }
            catch (PingException)
            {
                vars.connection_QUAD9 = "TIMEOUT";
            }
        }
    }
    public static void controldDNS()
    {
        string host = vars.ip_CONTROLDDNS;
        for (int i = 0; i < vars.ping_times + 1; i++)
        {
            try
            {
                Ping pingSender = new Ping();
                PingReply reply = pingSender.Send(host);

                if (reply.Status == IPStatus.Success)
                {
                    vars.ms_CONTROLDDNS = reply.RoundtripTime;
                    vars.connection_CONTROLD = "TRUE";
                    break;
                }
                else
                {
                    vars.connection_CONTROLD = "FALSE";
                }
            }
            catch (PingException)
            {
                vars.connection_CONTROLD = "TIMEOUT";
            }
        }
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
        string c = Console.ReadLine();
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
        }
        else
        {
            self_console.exit_choice(c);
        }
    }
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

        Thread googleDNStest = new Thread(self_info.googleDNS);
        Thread cloudflareDNStest = new Thread(self_info.cloudflareDNS);
        Thread controldDNStest = new Thread(self_info.controldDNS);
        Thread quad9DNStest = new Thread(self_info.quad9DNS);

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
                    } else
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
        Console.WriteLine($"{new string('▬', 120)}".Pastel("#ffffff"));
        Console.WriteLine("GOOGLE: ".Pastel("c500ff") + google);
        Console.WriteLine("CLOUDFLARE: ".Pastel("c500ff") + cloudflare);
        Console.WriteLine("CONTROLD: ".Pastel("c500ff") + controld);
        Console.WriteLine("QUAD9: ".Pastel("c500ff") + quad9);
        Console.WriteLine($"\n{self_console.oNumber(1)}" + "Try Again.".Pastel("#f58142"));
        Console.WriteLine($"\n{self_console.oNumber(0)}" + "Turn Back.".Pastel("#ff0000"));
        Console.WriteLine($"\n{new string('▬', 120)}".Pastel("#ffffff"));
        Console.Write("\nEnter A Number: ".Pastel("ff0000"));
        string c = Console.ReadLine();
        if(c == "1")
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
            choices.connection3();
        } else {
            self_console.exit_choice(c);
        }

    }
    public static void os4()
    {
        Console.Clear();
        try {
            ManagementObjectSearcher searcher =
                                                new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject os in searcher.Get())
            {
                string installDate = os["InstallDate"].ToString();

                DateTime parsedInstallDate = ManagementDateTimeConverter.ToDateTime(installDate);
                Console.WriteLine($"{new string('▬', 120)}".Pastel("#ffffff"));
                Console.WriteLine($"\nName: ".Pastel("c500ff") +                    $"{os["Caption"]}");
                Console.WriteLine($"Version: ".Pastel("c500ff") +                   $"{os["Version"]}");
                Console.WriteLine($"Manufacturer: ".Pastel("c500ff") +              $"{os["Manufacturer"]}");
                Console.WriteLine($"Installation Date: ".Pastel("c500ff") +         $"{parsedInstallDate}");
                Console.WriteLine($"Architecture: ".Pastel("c500ff") +              $"{os["OSArchitecture"]}");
                Console.WriteLine($"Registered User: ".Pastel("c500ff") +           $"{os["RegisteredUser"]}");
                Console.WriteLine($"Serial Number: ".Pastel("c500ff") +             $"{os["SerialNumber"]}");
                Console.WriteLine($"System Directory: ".Pastel("c500ff") +          $"{os["SystemDirectory"]}");
                Console.WriteLine($"Boot Device: ".Pastel("c500ff") +               $"{os["BootDevice"]}");
                Console.WriteLine($"Build Number: ".Pastel("c500ff") +              $"{os["BuildNumber"]}");
                Console.WriteLine($"Country Code: ".Pastel("c500ff") +              $"{os["CountryCode"]}");
                Console.WriteLine($"Current Time Zone: ".Pastel("c500ff") +         $"{os["CurrentTimeZone"]}");
                Console.WriteLine($"Encryption Level: ".Pastel("c500ff") +          $"{os["EncryptionLevel"]}");
                Console.WriteLine($"Free Physical Memory: ".Pastel("c500ff") +      $"{os["FreePhysicalMemory"]} bytes");
                Console.WriteLine($"Free Virtual Memory: ".Pastel("c500ff") +       $"{os["FreeVirtualMemory"]} bytes");
                Console.WriteLine($"Last Boot Up Time: ".Pastel("c500ff") +         $"{ManagementDateTimeConverter.ToDateTime(os["LastBootUpTime"].ToString())}");
                Console.WriteLine($"Local Date Time: ".Pastel("c500ff") +           $"{ManagementDateTimeConverter.ToDateTime(os["LocalDateTime"].ToString())}");
                Console.WriteLine($"Max Process Memory Size: ".Pastel("c500ff") +   $"{os["MaxProcessMemorySize"]} bytes");
                Console.WriteLine($"Number of Processes: ".Pastel("c500ff") +       $"{os["NumberOfProcesses"]}");
                Console.WriteLine($"Number of Users: ".Pastel("c500ff") +           $"{os["NumberOfUsers"]}");
                Console.WriteLine($"OS Language: ".Pastel("c500ff") +               $"{os["OSLanguage"]}");
                Console.WriteLine($"Product Type: ".Pastel("c500ff") +              $"{os["ProductType"]}");
                Console.WriteLine($"Registered Domain: ".Pastel("c500ff") +         $"{os["RegisteredDomain"]}");
                Console.WriteLine($"System Drive: ".Pastel("c500ff") +              $"{os["SystemDrive"]}");
                Console.WriteLine($"Total Swap Space Size: ".Pastel("c500ff") +     $"{os["TotalSwapSpaceSize"]} bytes");
                Console.WriteLine($"Total Virtual Memory Size: ".Pastel("c500ff") + $"{os["TotalVirtualMemorySize"]} bytes");
                Console.WriteLine($"Windows Directory: ".Pastel("c500ff") +         $"{os["WindowsDirectory"]}");
                Console.WriteLine($"\n{self_console.oNumber(0)}Turn Back.");
                Console.WriteLine($"\n{new string('▬', 120)}".Pastel("#ffffff"));
                Console.Write("\nEnter A Number: ".Pastel("ff0000"));
                string c = Console.ReadLine();
                self_console.exit_choice(c);
                Console.WriteLine($"{new string('▬', 120)}".Pastel("#ffffff"));
                Console.ReadLine();
            }
        } catch {
            Console.WriteLine($"\n{self_console.oNumber(0)}Turn Back.");
            Console.WriteLine($"\n{new string('▬', 120)}".Pastel("#ffffff"));
            Console.Write("\nEnter A Number: ".Pastel("ff0000"));
            string c = Console.ReadLine();
            self_console.exit_choice(c);
            Console.WriteLine($"{new string('▬', 120)}".Pastel("#ffffff"));
            Console.ReadLine();

        }
    }
}
class god_i_hate_math
{
    public static double MbToGb(int megabytes)
    {
        double gigabytes = megabytes / 1024.0; // 1 GB = 1024 MB
        return gigabytes;
    }
    static double BytesToGB(long bytes)
    {
        /*            
         *            BYTES 
         * GB = -----------------
         *       1024.1024.1024
        */
        return (double)bytes / (1024 * 1024 * 1024);
    }
}