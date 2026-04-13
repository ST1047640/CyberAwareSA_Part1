using System;

namespace CyberAwareSA.Core
{
    public class BotEngine
    {
        // Requirement: Automatic Property
        public string UserName { get; set; }

        public string GetResponse(string userInput)
        {
            if (string.IsNullOrWhiteSpace(userInput))
            {
                return "CyberCore detected an empty input. Please ask about phishing, passwords, or safe browsing.";
            }

            string input = userInput.ToLower();

            // TOPIC 1: Phishing
            if (input.Contains("phishing") || input.Contains("scam"))
            {
                return "Phishing is a major threat in SA. Scammers use fake SMS (Smishing) or emails to steal bank details. Never click links in messages from unknown numbers!";
            }

            // TOPIC 2: Passwords
            if (input.Contains("password") || input.Contains("secure"))
            {
                return "A strong password is your first line of defense. Use a passphrase like 'Springboks#2026'—it's much harder to crack than simple words.";
            }

            // TOPIC 3: Safe Browsing
            if (input.Contains("browsing") || input.Contains("website") || input.Contains("internet"))
            {
                return "Always look for the 'padlock' icon and 'https' in your browser's address bar. Avoid using public Wi-Fi for banking or shopping!";
            }

            // General Info
            if (input.Contains("purpose") || input.Contains("who are you"))
            {
                return "I am CyberCore, an AI assistant built to educate South Africans on identifying and stopping cyber threats.";
            }

            // Requirement 5: Default Response
            return "CyberCore doesn't have specific data on that. Try asking about 'phishing', 'passwords', or 'safe browsing'.";
        }
    }
}