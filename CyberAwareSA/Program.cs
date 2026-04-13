// Project: CyberAwareSA
// Student: ST10477640
using System;
using CyberAwareSA.UI;
using CyberAwareSA.Core;

namespace CyberAwareSA
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Initialization
            BotEngine myBot = new BotEngine();

            // 2. Startup Sequence
            InterfaceManager.PlayVoiceGreeting();
            InterfaceManager.DisplayAsciiArt();

            // 3. User Onboarding (Question 1)
            InterfaceManager.TypeEffect(">>> CYBERCORE ONLINE. SECURE CONNECTION ESTABLISHED...", ConsoleColor.DarkGray);
            InterfaceManager.TypeEffect("Hello! I am CyberCore. To begin, what is your name?", ConsoleColor.Yellow);

            Console.Write("\n[NAME]: ");
            string nameInput = Console.ReadLine();
            myBot.UserName = string.IsNullOrWhiteSpace(nameInput) ? "Citizen" : nameInput;

            InterfaceManager.DrawDivider();

            // Providing the 3 options clearly (Question 2 & Instructions)
            InterfaceManager.TypeEffect($"Welcome, {myBot.UserName}. I can assist you with three main areas:", ConsoleColor.Cyan);
            InterfaceManager.TypeEffect("1. Phishing Scams\n2. Password Security\n3. Safe Browsing Tips", ConsoleColor.White);
            InterfaceManager.TypeEffect("\nWhat would you like to learn about first?", ConsoleColor.Yellow);
            InterfaceManager.DrawDivider();

            // 4. Main Interaction Loop
            bool isRunning = true;
            while (isRunning)
            {
                Console.Write($"\n[{myBot.UserName}]: ");
                string userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput)) continue;

                if (userInput.ToLower() == "exit" || userInput.ToLower() == "quit")
                {
                    InterfaceManager.TypeEffect("\nClosing secure connection. Stay vigilant, South Africa!", ConsoleColor.Red);
                    isRunning = false;
                }
                else
                {
                    // Visual feedback
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("CyberCore is analyzing query...");
                    System.Threading.Thread.Sleep(600);
                    Console.Write("\r" + new string(' ', 35) + "\r");

                    // Logic from BotEngine
                    string botResponse = myBot.GetResponse(userInput);

                    Console.Write("[CYBERCORE]: ");
                    InterfaceManager.TypeEffect(botResponse, ConsoleColor.Green);
                    InterfaceManager.DrawDivider();

                    // Keep prompting for the next question
                    InterfaceManager.TypeEffect("Do you have another question? (Type 'exit' to quit)", ConsoleColor.DarkGray);
                }
            }
        }
    }
}
