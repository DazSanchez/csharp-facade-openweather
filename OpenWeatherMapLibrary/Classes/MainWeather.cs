using System.Text.Json.Serialization;

namespace OpenWeatherMapLibrary.Classes
{
  public class MainWeather
  {
    [JsonPropertyName("temp")]
    public float Temp { get; set; }
    [JsonPropertyName("feels_like")]
    public float FeelsLike { get; set; }
    [JsonPropertyName("temp_min")]
    public float TempMin { get; set; }
    [JsonPropertyName("temp_max")]
    public float TempMax { get; set; }
    [JsonPropertyName("pressure")]
    public short Pressure { get; set; }
    [JsonPropertyName("humidity")]
    public byte Humidity { get; set; }
    [JsonPropertyName("sea_level")]
    public short SeaLevel { get; set; }
    [JsonPropertyName("grnd_level")]
    public short GrndLevel { get; set; }
  }
}