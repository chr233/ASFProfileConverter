using System.Text.Json.Serialization;

namespace ASFProfileConverter
{
    internal sealed record MaFileData
    {
        [JsonPropertyName("account_name")]
        public string? AccountName { get; set; }

        [JsonPropertyName("shared_secret")]
        public string? SharedSecret { get; set; }
        
        [JsonPropertyName("serial_number")]
        public string? SerialNumber { get; set; }
        
        [JsonPropertyName("revocation_code")]
        public string? RevocationCode { get; set; }
    }
}
