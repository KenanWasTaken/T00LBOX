using Microsoft.Win32;
using Pastel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net.NetworkInformation;
using System.Net;
using System.Text.RegularExpressions;

namespace INFO
{
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
            }
            catch (Exception e)
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
        public static string getWifiPasswd(string ssid)
        {
            Process process = new Process();
            string pattern = @"Key Content\s+:\s+(\S+)";

            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/c netsh wlan show profiles \"{ssid}\" key=clear";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();

            string output = process.StandardOutput.ReadToEnd(); // Read the output after process completion

            process.WaitForExit();

            Regex regex = new Regex(pattern);
            Match match = regex.Match(output);
            if (match.Success)
            {
                string result = match.Groups[1].Value;

                int index = result.IndexOf(":") + 1;

                string result2 = result.Substring(index);
                return result2;
            }
            else
            {
                return "SSID NOT FOUND...";
            }
        }
        public static string GetSsid()
        {
            string ssid = "";
            Process process = new Process();
            process.StartInfo.FileName = "netsh";
            process.StartInfo.Arguments = "wlan show interfaces";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();

            using (StreamReader reader = process.StandardOutput)
            {
                string result = reader.ReadToEnd();
                int ssidIndex = result.IndexOf("SSID", StringComparison.OrdinalIgnoreCase);
                if (ssidIndex != -1)
                {
                    int colonIndex = result.IndexOf(':', ssidIndex);
                    if (colonIndex != -1)
                    {
                        int lineBreakIndex = result.IndexOfAny(new char[] { '\r', '\n' }, colonIndex);
                        if (lineBreakIndex != -1)
                        {
                            ssid = result.Substring(colonIndex + 1, lineBreakIndex - colonIndex - 1).Trim();
                        }
                    }
                }
            }

            process.WaitForExit();
            return ssid;
        }
        public static List<string> GetNetworkAdapterNames()
        {
            List<string> adapterNames = new List<string>();

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter");

                foreach (ManagementObject obj in searcher.Get())
                {
                    string adapterName = obj["Name"] as string;
                    adapterNames.Add(adapterName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return adapterNames;
        }

    }

}
