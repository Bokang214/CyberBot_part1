using System;
using System.Media;
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
            PlayVoiceGreeting();
            AskUserName();
            ChatLoop();
        }

        
    }
}
