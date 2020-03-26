﻿using System;
using System.IO;

namespace CustomSteamPresence
{
    class TextManager
    {
        private const string FILE_PATH = "/UserData/CustomSteamPresenceTexts.txt";
        private string[] possibleStatuses = null;
        private Random rand = new Random();

        private const string DEFAULT_CONFIG =
@"Beating some levels [Hard]
Punching wood!
Murdering bloqs
Finally I can beat Expert maps";
        
        internal void Load()
        {
            string fullpath = Environment.CurrentDirectory + FILE_PATH;
            if (!File.Exists(fullpath))
            {
                Plugin.logger.Info("No config found, writing default");
                File.WriteAllText(fullpath, DEFAULT_CONFIG);
                possibleStatuses = DEFAULT_CONFIG.Split('\n');
            }
            else possibleStatuses = File.ReadAllLines(fullpath);
            Plugin.logger.Info("Read " + possibleStatuses.Length + " custom steam presence texts");
        }

        internal string GetRandomText()
        {
            if (possibleStatuses.Length == 0) return "";
            return possibleStatuses[rand.Next(possibleStatuses.Length)];
        }
    }
}
