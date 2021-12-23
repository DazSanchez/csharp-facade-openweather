using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenWeatherMapLibrary.Classes
{
  public class WeatherResponse
  {
    [JsonPropertyName("base")]
    public string Base { get; set; }
    [JsonPropertyName("visibility")]
    public int Visibility { get; set; }
    [JsonPropertyName("dt")]
    public uint Dt { get; set; }
    [JsonPropertyName("timezone")]
    public int Timezone { get; set; }
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("cod")]
    public int Cod { get; set; }
    [JsonPropertyName("coord")]
    public Coordinates Coord { get; set; }
    [JsonPropertyName("weather")]
    public IEnumerable<WeatherCondition> Weather { get; set; }
    [JsonPropertyName("main")]
    public MainWeather Main { get; set; }
    [JsonPropertyName("wind")]
    public WindCondition Wind { get; set; }
    [JsonPropertyName("clouds")]
    public CloudsCondition Clouds { get; set; }
    [JsonPropertyName("rain")]
    public VolumeByTimeCondition Rain { get; set; }
    [JsonPropertyName("snow")]
    public VolumeByTimeCondition Snow { get; set; }
    [JsonPropertyName("sys")]
    public InternalMetadata Sys { get; set; }

    public override string ToString()
    {
      return JsonSerializer.Serialize(this);
    }
  }
}