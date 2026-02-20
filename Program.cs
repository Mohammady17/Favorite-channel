using System;

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            int channelNumber = 0;
            string userOpt;

            do
            {
                channelNumber++;
                Console.WriteLine($"**Channel {channelNumber}**");
                Console.WriteLine("Do you love this channel? (yes/no)");
                userOpt = Console.ReadLine().ToUpper();

                if (userOpt != "YES" && userOpt != "NO")
                {
                    ValidateUserInput();
                }

            } while (userOpt != "YES");
            Console.WriteLine($"Enjoy the channel {channelNumber}!");
            Environment.Exit(0);
        }

        static void ValidateUserInput()
        {
            Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            Main();
        }
    }
}