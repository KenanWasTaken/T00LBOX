
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
using OS;

class Program
{
    static void Main(string[] args)
    {
        
        Thread animationThread = new Thread(() => consoleShows.t1tle("                                                                                                                  T00LBOX | CREATED BY KENANWASTAKEN                                                                       ", 10));
        animationThread.Start();
        IntPtr ptr = self_console.GetConsoleWindow();
        self_console.MoveWindow(ptr, screen.screenCenterX(), screen.screenCenterY(), vars.consoleW, vars.consoleH, true);
        consoleShows.creator();
        consoleShows.t00lbox();
        consoleShows.info();

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
                os.os4();
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
}