using System.Text.Json.Serialization;
using RestSharp;

var client = new RestClient(new Uri("https://api.coingecko.com/api/v3/"));
var req = new RestRequest("simple/price?ids=bitcoin&vs_currencies=GBP%2CUSD");
var resp = await client.GetAsync<Root>(req);

Console.WriteLine("Current BTC Price:");
Console.WriteLine($"USD: £{resp.Bitcoin.Usd}");
Console.WriteLine($"GBP: ${resp.Bitcoin.Gbp}");
internal class Bitcoin
{
    [JsonPropertyName("gbp")] public double Gbp { get; set; }
    [JsonPropertyName("usd")] public double Usd { get; set; }
}

internal class Root
{
    [JsonPropertyName("bitcoin")] public Bitcoin Bitcoin { get; set; }
}