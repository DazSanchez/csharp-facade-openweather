using System.Text.Json.Serialization;

namespace OpenWeatherMapLibrary.Classes
{
  public class Coordinates
  {
    [JsonPropertyName("lat")]
    public double Lat { get; set; }
    [JsonPropertyName("lon")]
    public double Lon { get; set; }
  }
}