using System.Text.Json.Serialization;

namespace CodeQuery.Postman.UI.Models;

#pragma warning disable CS8618, CS8601, CS8603
public partial class Raw
{
    [JsonPropertyName("headerFamily")]
    public PostmanPreviewlanguage HeaderFamily { get; set; }

    [JsonPropertyName("language")]
    public PostmanPreviewlanguage Language { get; set; }
}