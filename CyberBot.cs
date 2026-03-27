using System;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace CyberBot_part1
{
    public class CyberBot
    {
        private string userName;

        public void Start()
        {
            Console.Title = "Cybersecurity Awareness Bot";

            ShowHeader();
            PlayVoiceGreeting();
            GetUserName();
            WelcomeUser();
            MenuLoop();
        }

        // =========================
        // HEADER
        // =========================
        private void ShowHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=================================================");
            Console.WriteLine("========CYBERSECURITY AWARENESS BOT==============");
            Console.WriteLine("=================================================");

            Console.WriteLine(@"
      ____      _               ____        _   
     / ___|   _| |__   ___ _ __| __ )  ___ | |_ 
    | |  | | | | '_ \ / _ \ '__|  _ \ / _ \| __|
    | |__| |_| | |_) |  __/ |  | |_) | (_) | |_ 
     \____\__, |_.__/ \___|_|  |____/ \___/ \__|
          |___/                                 
           Stay Safe Online!
");

            Console.ResetColor();
        }

        // =========================
        // VOICE GREETING (MP3/WAV)
        // =========================
        private void PlayVoiceGreeting()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "welcome.wav");

                if (File.Exists(path))
                {
                    Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
                    Thread.Sleep(3000); // allow it to play briefly
                }
                else
                {
                    Console.WriteLine("(Audio file not found)");
                }
            }
            catch
            {
                Console.WriteLine("(Could not play audio)");
            }
        }

        // =========================
        // GET NAME
        // =========================
        private void GetUserName()
        {
            Console.Write("\nEnter your name: ");
            userName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.Write("Name cannot be empty. Try again: ");
                userName = Console.ReadLine();
            }
        }

        // =========================
        // WELCOME
        // =========================
        private void WelcomeUser()
        {
            TypeEffect($"\nHello, {userName}! Welcome to the Cybersecurity Awareness Bot.");
            TypeEffect("I'm here to help you stay safe online.\n");
        }

        // =========================
        // MENU LOOP
        // =========================
        private void MenuLoop()
        {
            while (true)
            {
                ShowMenu();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\n{userName}> ");
                Console.ResetColor();

                string choice = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(choice))
                {
                    ShowError("Invalid input. Please select an option.");
                    continue;
                }

                switch (choice)
                {
                    case "1":
                        TypeEffect("My purpose is to educate you about cybersecurity and help you stay safe online.");
                        break;

                    case "2":
                        TypeEffect("Phishing is a scam where attackers trick you into giving personal information through fake emails or websites.");
                        break;

                    case "3":
                        TypeEffect("Use strong passwords with letters, numbers, and symbols. Avoid using personal information and never reuse passwords.");
                        break;

                    case "4":
                        TypeEffect("Safe browsing means visiting secure websites (https), avoiding suspicious links, and keeping your software updated.");
                        break;

                    case "5":
                    case "exit":
                        TypeEffect($"Goodbye {userName}, stay safe online!");
                        return;

                    default:
                        ShowError("Please choose a valid option (1–5).");
                        break;
                }
            }
        }

        // =========================
        // MENU DISPLAY
        // =========================
        private void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\n================ MENU ================");
            Console.ResetColor();

            Console.WriteLine("1. What is my purpose?");
            Console.WriteLine("2. Phishing");
            Console.WriteLine("3. Passwords");
            Console.WriteLine("4. Safe Browsing");
            Console.WriteLine("5. Exit");
        }

        // =========================
        // HELPERS
        // =========================
        private void TypeEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(15);
            }
            Console.WriteLine();
        }
        private void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

