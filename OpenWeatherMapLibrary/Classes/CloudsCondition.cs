using System.Text.Json.Serialization;

namespace OpenWeatherMapLibrary.Classes
{
  public class CloudsCondition
  {
    [JsonPropertyName("all")]
    public byte All { get; set; }
  }
}