
//////////////////////////
//        SYSTEM D.     //
//////////////////////////

using Pastel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;

using USER;
using CONSOLESHOW;
using SCREEN;
using INFO;
using CONNECTION;
using CNAME;

class Program
{
    static void Main(string[] args)
    {
        
        Thread animationThread = new Thread(() => consoleShows.t1tle("                                                                                                                  T00LBOX | CREATED BY KENANWASTAKEN                                                                       ", 10));
        animationThread.Start();
        IntPtr ptr = self_console.GetConsoleWindow();
        self_console.MoveWindow(ptr, screen.screenCenterX(), screen.screenCenterY(), vars.consoleW, vars.consoleH, true);
        CONSOLESHOW.consoleShows.creator();
        CONSOLESHOW.consoleShows.t00lbox();
        CONSOLESHOW.consoleShows.info();

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
    static public List<string> adapters = self_info.GetNetworkAdapterNames();
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
                user.user1();
                break;
            case "2":
                cname.cname2();
                break;
            case "3":
                connection.connection3();
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
                CONSOLESHOW.consoleShows.t00lbox();
                CONSOLESHOW.consoleShows.info();
                break;
            default:
                Console.Clear();
                Console.WriteLine("No Choice Found. Turning Main Menu...".Pastel("#ff0000"));
                Thread.Sleep(1000);
                CONSOLESHOW.consoleShows.t00lbox();
                CONSOLESHOW.consoleShows.info();
                break;
        }
    }
    public static void internetreset()
    {
        string command = "netsh winsock reset & netsh int ip reset & ipconfig /release & ipconfig /renew & ipconfig /flushdns";


        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            Arguments = "/c " + command,
            Verb = "runas",
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        Process process = new Process
        {
            StartInfo = psi
        };
        process.Start();

        string output = process.StandardOutput.ReadToEnd();
        Console.WriteLine(output.Pastel("#60f542"));
        Thread.Sleep(2000);

        process.WaitForExit();
    }
    public static void pc_restart()
    {
        Process process = new Process();

        process.StartInfo.FileName = "cmd.exe";
        process.StartInfo.Arguments = $"/c shutdown -r -t 00";
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.CreateNoWindow = true;
        process.Start();
        process.WaitForExit();
    }
    public static void setMAC(string mac)
    {

    }
}
class choices
{
    //HOLY FUCK IM NOT DOIN DAT 😭


    public static void os4()
    {
        Console.Clear();
        try
        {
            ManagementObjectSearcher searcher =
                                                new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject os in searcher.Get())
            {
                string installDate = os["InstallDate"].ToString();

                DateTime parsedInstallDate = ManagementDateTimeConverter.ToDateTime(installDate);
                Console.WriteLine($"{new string('▬', 120)}".Pastel("#ffffff"));
                Console.WriteLine($"\nName: ".Pastel("c500ff") + $"{os["Caption"]}");
                Console.WriteLine($"Version: ".Pastel("c500ff") + $"{os["Version"]}");
                Console.WriteLine($"Manufacturer: ".Pastel("c500ff") + $"{os["Manufacturer"]}");
                Console.WriteLine($"Installation Date: ".Pastel("c500ff") + $"{parsedInstallDate}");
                Console.WriteLine($"Architecture: ".Pastel("c500ff") + $"{os["OSArchitecture"]}");
                Console.WriteLine($"Registered User: ".Pastel("c500ff") + $"{os["RegisteredUser"]}");
                Console.WriteLine($"Serial Number: ".Pastel("c500ff") + $"{os["SerialNumber"]}");
                Console.WriteLine($"System Directory: ".Pastel("c500ff") + $"{os["SystemDirectory"]}");
                Console.WriteLine($"Boot Device: ".Pastel("c500ff") + $"{os["BootDevice"]}");
                Console.WriteLine($"Build Number: ".Pastel("c500ff") + $"{os["BuildNumber"]}");
                Console.WriteLine($"Country Code: ".Pastel("c500ff") + $"{os["CountryCode"]}");
                Console.WriteLine($"Current Time Zone: ".Pastel("c500ff") + $"{os["CurrentTimeZone"]}");
                Console.WriteLine($"Encryption Level: ".Pastel("c500ff") + $"{os["EncryptionLevel"]}");
                Console.WriteLine($"Free Physical Memory: ".Pastel("c500ff") + $"{os["FreePhysicalMemory"]} bytes");
                Console.WriteLine($"Free Virtual Memory: ".Pastel("c500ff") + $"{os["FreeVirtualMemory"]} bytes");
                Console.WriteLine($"Last Boot Up Time: ".Pastel("c500ff") + $"{ManagementDateTimeConverter.ToDateTime(os["LastBootUpTime"].ToString())}");
                Console.WriteLine($"Local Date Time: ".Pastel("c500ff") + $"{ManagementDateTimeConverter.ToDateTime(os["LocalDateTime"].ToString())}");
                Console.WriteLine($"Max Process Memory Size: ".Pastel("c500ff") + $"{os["MaxProcessMemorySize"]} bytes");
                Console.WriteLine($"Number of Processes: ".Pastel("c500ff") + $"{os["NumberOfProcesses"]}");
                Console.WriteLine($"Number of Users: ".Pastel("c500ff") + $"{os["NumberOfUsers"]}");
                Console.WriteLine($"OS Language: ".Pastel("c500ff") + $"{os["OSLanguage"]}");
                Console.WriteLine($"Product Type: ".Pastel("c500ff") + $"{os["ProductType"]}");
                Console.WriteLine($"Registered Domain: ".Pastel("c500ff") + $"{os["RegisteredDomain"]}");
                Console.WriteLine($"System Drive: ".Pastel("c500ff") + $"{os["SystemDrive"]}");
                Console.WriteLine($"Total Swap Space Size: ".Pastel("c500ff") + $"{os["TotalSwapSpaceSize"]} bytes");
                Console.WriteLine($"Total Virtual Memory Size: ".Pastel("c500ff") + $"{os["TotalVirtualMemorySize"]} bytes");
                Console.WriteLine($"Windows Directory: ".Pastel("c500ff") + $"{os["WindowsDirectory"]}");
                Console.WriteLine($"\n{self_console.oNumber(0)}Turn Back.");
                Console.WriteLine($"\n{new string('▬', 120)}".Pastel("#ffffff"));
                Console.Write("\nEnter A Number: ".Pastel("ff0000"));
                string c = Console.ReadLine();
                self_console.exit_choice(c);
                Console.WriteLine($"{new string('▬', 120)}".Pastel("#ffffff"));
                Console.ReadLine();
            }
        }
        catch
        {
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