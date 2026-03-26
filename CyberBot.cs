using System;
using System.Diagnostics;
using System.IO;
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

    }
}
