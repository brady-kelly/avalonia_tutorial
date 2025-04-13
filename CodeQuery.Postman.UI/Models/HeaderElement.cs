using System.Text.Json.Serialization;

namespace CodeQuery.Postman.UI.Models;

#pragma warning disable CS8618, CS8601, CS8603
public partial class HeaderElement
{
    [JsonPropertyName("key")]
    public string Key { get; set; }

    [JsonPropertyName("value")]
    public string Value { get; set; }
}