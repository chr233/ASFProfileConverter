using System.Text.Json.Serialization;

namespace ASFProfileConverter
{
    internal sealed record MaFileData
    {
        [JsonPropertyName("account_name")]
        public string? AccountName { get; set; }
    }
}
