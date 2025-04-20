using System;
using System.Media;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace PROGPOEI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Cybersecurity Awareness Bot";

            
            DisplayAsciiLogo();


            
            RunChatbot();
        }

        static void DisplayAsciiLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
           ________________________________________________
            /                                                \
           |    _________________________________________     |
           |   |                                         |    |
           |   |  C:\> _                                 |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |_________________________________________|    |
           |                                                  |
            \_________________________________________________/
                   \___________________________________/
                ___________________________________________
             _-'    .-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.  --- `-_
          _-'.-.-. .---.-.-.-.-.-.-.-.-.-.-.-.-.-.-.--.  .-.-.`-_
       _-'.-.-.-. .---.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-`__`. .-.-.-.`-_
    _-'.-.-.-.-. .-----.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-----. .-.-.-.-.`-_
 _-'.-.-.-.-.-. .---.-. .-------------------------. .-.---. .---.-.-.-.`-_
:-------------------------------------------------------------------------:
`---._.-------------------------------------------------------------._.---'
");
            Console.ResetColor();
            Console.WriteLine();
        }

        

        static void RunChatbot()
        {
            Dictionary<string, string> responses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "hello", "Hello! How can I help you with cybersecurity today?" },
                { "password", "Good passwords are at least 12 characters long, use a mix of letters, numbers, and symbols, and shouldn't be used across multiple sites." },
                { "phishing", "Phishing attacks are fraudulent attempts to obtain sensitive information by disguising as trustworthy entities. Always verify the sender's email address and don't click suspicious links." },
                { "update", "Keeping your software updated is crucial for security. Updates often contain patches for security vulnerabilities." },
                { "backup", "Regular backups are essential. Follow the 3-2-1 rule: 3 copies of data, on 2 different media types, with 1 copy stored off-site." },
                { "2fa", "Two-factor authentication adds an extra layer of security by requiring something you know (password) and something you have (like your phone)." },
                { "vpn", "A VPN (Virtual Private Network) encrypts your internet connection, providing privacy and security especially on public Wi-Fi networks." },
                { "malware", "Malware is malicious software designed to damage or gain unauthorized access to your system. Use reputable antivirus software and avoid suspicious downloads." },
                { "help", "You can ask me about: password security, phishing, software updates, backups, two-factor authentication (2fa), VPNs, malware, or type 'exit' to quit." },
                { "exit", "Goodbye! Stay safe online!" }
            };

            bool isRunning = true;

            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the Cybersecurity Awareness Bot!");
            Console.WriteLine("I'm here to help you stay safe online.");
            Console.WriteLine("Type 'help' to see what I can assist you with, or 'exit' to quit.");
            Console.ResetColor();

            while (isRunning)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("> ");
                string input = Console.ReadLine()?.Trim() ?? "";
                Console.ResetColor();

               
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please type a question or command. Type 'help' for assistance.");
                    Console.ResetColor();
                    continue;
                }

                
                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(responses["exit"]);
                    Console.ResetColor();
                    isRunning = false;
                    continue;
                }

                
                bool foundResponse = false;
                foreach (var keyword in responses.Keys)
                {
                    if (input.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(responses[keyword]);
                        Console.ResetColor();
                        foundResponse = true;
                        break;
                    }
                }

                
                if (!foundResponse)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("I'm not sure how to help with that. Try asking about common cybersecurity topics or type 'help' for options.");
                    Console.ResetColor();
                }
            }
        }
    }
}