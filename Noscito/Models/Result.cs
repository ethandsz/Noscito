using System.Text.Json.Serialization;

namespace Noscito;

public class Result
{
    [JsonPropertyName("list")]
    public List<Wick>? Wicks { get; set; }
    
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }
    
    [JsonPropertyName("price")]
    public string CurrentPrice { get; set; }
}