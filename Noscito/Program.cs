using Noscito;

var httpRequester = HttpRequester.Instance();
var endpoint = new Uri("https://api.bybit.com/spot/v3/public/quote/kline?symbol=BTCUSDT&interval=4h&limit=100");
try 
{
    var result = await httpRequester.GetFromJsonAsync<ByBitResponse>(endpoint);
    var wicks = result.Result.Wicks; 
    Console.WriteLine("Ry");
} 
catch (Exception ex)
{
    Console.WriteLine($"An error occurred while retrieving the data: {ex.Message}");
}