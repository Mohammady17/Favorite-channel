using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int channelNumber = 0;
            string userOpt;
            do
            {
                channelNumber++;
                Console.WriteLine($"**Channel {channelNumber}**");
                Console.WriteLine("Do you love this channel? (yes/no)");
                userOpt = Console.ReadLine().ToUpper();

                if (userOpt == "YES")
                {
                    Console.WriteLine($"Enjoy watching channel {channelNumber}");
                }

            } while (userOpt == "NO");
            Environment.Exit(0);
        }
    }
}