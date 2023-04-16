using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
