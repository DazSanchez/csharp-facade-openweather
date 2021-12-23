using System.Text.Json.Serialization;

namespace OpenWeatherMapLibrary.Classes
{
  public class WindCondition
  {
    [JsonPropertyName("speed")]
    public float Speed { get; set; }
    [JsonPropertyName("deg")]
    public short Deg { get; set; }
    [JsonPropertyName("gust")]
    public float Gust { get; set; }
  }
}