using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CodeQuery.Postman.UI.Models;

#pragma warning disable CS8618, CS8601, CS8603
public partial class Formdatum
{
    [JsonPropertyName("key")]
    public string Key { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public string Value { get; set; }

    [JsonPropertyName("type")]
    public TypeEnum Type { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("src")]
    public List<object> Src { get; set; }
}