using Pastel;
using System;

namespace USER
{
    public static class user
    {
        public static void user1()
        {
            Console.Clear();
            Console.WriteLine($"\n{new string('▬', 120)}".Pastel("#ffffff"));
            Console.WriteLine($"CURRENT USER: " + $"{INFO.self_info.user()}".Pastel("#ff0000"));
            Console.WriteLine("\n-----".Pastel("#9900ff") + "USER LIST".Pastel("#00ff1a") + "-----".Pastel("#9900ff"));
            Console.Write(vars.users);
            Console.WriteLine("-------------------".Pastel("#9900ff"));
            Console.WriteLine($"\n{self_console.oNumber(0)}Turn Back.");
            Console.WriteLine($"\n{new string('▬', 120)}".Pastel("#ffffff"));
            Console.Write("\nEnter A Number: ".Pastel("ff0000"));
            string c = Console.ReadLine();
            self_console.exit_choice(c);
        }
    }
}
