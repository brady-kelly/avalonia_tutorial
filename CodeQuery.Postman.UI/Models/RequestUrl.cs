using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CodeQuery.Postman.UI.Models;

#pragma warning disable CS8618, CS8601, CS8603
public partial class RequestUrl
{
    [JsonPropertyName("raw")]
    public string Raw { get; set; }

    [JsonPropertyName("host")]
    public List<Host> Host { get; set; }

    [JsonPropertyName("path")]
    public List<string> Path { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("variable")]
    public List<Variable> Variable { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public List<Query> Query { get; set; }
}