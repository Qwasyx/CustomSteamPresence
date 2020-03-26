namespace CustomSteamPresence
{
    class CustomRichPresenceData : IRichPresenceData
    {
        public string apiName => "CustomRichPresenceData";
        public string localizedDescription => data;

        private readonly string data;
        public CustomRichPresenceData(string data)
        {
            this.data = data;
        }
    }
}
