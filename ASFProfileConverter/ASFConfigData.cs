namespace ASFProfileConverter
{
    internal class ASFConfigData
    {
        public string? SteamLogin { get; set; }
        public string? SteamPassword { get; set; }
        public bool Enabled { get; set; } = true;
        public bool Paused { get; set; } = true;
    }
}
