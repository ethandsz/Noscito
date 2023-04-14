using System.Text.Json.Serialization;

namespace Noscito.Api.Models;

public class Result
{
    [JsonPropertyName("list")]
    public List<CandleStick>? Wicks { get; set; }
    
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }
    
    [JsonPropertyName("price")]
    public string CurrentPrice { get; set; }
}