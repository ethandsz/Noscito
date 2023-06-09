﻿using System.Text.Json.Serialization;

namespace Noscito.Api.Models;

public class ByBitResponse
{
    [JsonPropertyName("retMsg")]
    public string StatusMessage { get; set; }
    
    [JsonPropertyName("result")]
    public Result Result { get; set; }
}