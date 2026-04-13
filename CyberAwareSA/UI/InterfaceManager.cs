// This class handles all user input and console output formatting
using System;
using System.Media;
using System.Threading;

namespace CyberAwareSA.UI
{
    public static class InterfaceManager
    {
        public static void PlayVoiceGreeting()
        {
            try
            {
                // Ensure greeting.wav is in Assets folder & 'Copy to Output' is 'Copy if newer'
                SoundPlayer player = new SoundPlayer("Assets/greeting.wav");
                player.Play();
            }
            catch { /* Fails silently if no audio device */ }
        }

        public static void DisplayAsciiArt()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
    ############################################################
    #                                                          #
    #    ██████╗██╗   ██╗██████╗ ███████╗██████╗               #
    #   ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗              #
    #   ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝              #
    #   ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗              #
    #   ╚██████╗   ██║   ██████╔╝███████╗██║  ██║              #
    #    ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝              #
    #                                                          #
    #               [ CYBERCORE: SECURITY BOT ]                #
    #                 ST1047640 | VERSION 1.0                  #
    #                                                          #
    ############################################################");
            Console.ResetColor();
        }

        public static void TypeEffect(string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void DrawDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(new string('=', 64));
            Console.ResetColor();
        }
    }
}
