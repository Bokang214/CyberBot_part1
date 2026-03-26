using System;

using System.Threading;

namespace CyberBot_part1
{
    public class CyberBot
    {
        private string userName = "";
        public void Start()
        {
            Console.Title = "CyberSecurity Awareness Bot";

            ShowHeader();
            //PlayVoiceGreeting();
            AskUserName();
            ChatLoop();
        }

        //=====================
        //HEADER + ASCII ART
        //=====================
        private void ShowHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("======================================================");
            Console.WriteLine("============CYBERSECURITY AWARENESS BOT===============");
            Console.WriteLine("======================================================");
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

        //===================
        //VOICE GREETING
        //===================

        //private void PlayVoiceGreeting()
        //{
        //    try
        //    {
        //        string path = "welcome.wav"; // file in project folder
        //        SoundPlayer player = new SoundPlayer(path);
        //        player.Load();        // loads audio
        //        player.PlaySync();    // plays before continuing
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        Console.WriteLine("🔊 Voice greeting could not play.");
        //        Console.WriteLine("Error: " + ex.Message);
        //        Console.ResetColor();
        //    }
        //}




        private void AskUserName()
        {
            Console.Write("\nEnter your name please: ");
            userName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.Write("Name cannot be empty. Please enter your name: ");
                userName = Console.ReadLine();
            }

            TypeEffect($"\nWelcome, {userName}! I'm here to help you stay safe online.\n");

        }
        
        //===================
        // MAIN CHAT LOOP
        //===================

        private void ChatLoop()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nAsk a questions about Phishing, Safe browsing or Passwords(type exit to leave the chat): ");
                Console.ResetColor();

                string input = Console.ReadLine().ToLower();

                //input validation
                if (string.IsNullOrWhiteSpace(input))
                {
                    ShowError("I didn't quite understand that. Could you rephrase?");
                    continue;

                }
                if (input == "exit")
                {
                    TypeEffect($"Goodbye {userName}, stay safe online and think before you click! see ya!");
                    break;
                }

                HandleResponse(input);
            }

        }
    }
}
