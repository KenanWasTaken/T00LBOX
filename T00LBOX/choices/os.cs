using Pastel;
using System;
using System.Management;

namespace OS
{
    public static class os
    {
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
}
