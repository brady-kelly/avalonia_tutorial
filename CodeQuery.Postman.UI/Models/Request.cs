using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CodeQuery.Postman.UI.Models;

#pragma warning disable CS8618, CS8601, CS8603
public partial class Request
{
    [JsonPropertyName("name")]
    public string Name {get; set;}

    [JsonPropertyName("method")]
    public Method Method { get; set; }

    [JsonPropertyName("header")]
    public List<HeaderElement> Header { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("body")]
    public RequestBody Body { get; set; }

    [JsonPropertyName("url")]
    public RequestUrl Url { get; set; }
}

