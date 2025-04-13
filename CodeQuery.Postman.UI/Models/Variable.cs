using System.Text.Json.Serialization;

namespace CodeQuery.Postman.UI.Models;

public partial class Variable
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}