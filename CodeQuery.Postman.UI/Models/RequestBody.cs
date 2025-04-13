using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CodeQuery.Postman.UI.Models;

#pragma warning disable CS8618, CS8601, CS8603
public partial class RequestBody
{
    [JsonPropertyName("mode")]
    public Mode Mode { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("raw")]
    public string Raw { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public Options Options { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("formdata")]
    public List<Formdatum> Formdata { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("urlencoded")]
    public List<Formdatum> Urlencoded { get; set; }
}