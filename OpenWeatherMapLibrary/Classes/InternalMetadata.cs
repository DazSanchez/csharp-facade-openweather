using System.Text.Json.Serialization;

namespace OpenWeatherMapLibrary.Classes
{
  public class InternalMetadata
  {
    [JsonPropertyName("type")]
    public byte Type { get; set; }
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("message")]
    public string Message { get; set; }
    [JsonPropertyName("country")]
    public string Country { get; set; }
    [JsonPropertyName("sunrise")]
    public int Sunrise { get; set; }
    [JsonPropertyName("sunset")]
    public int Sunset { get; set; }
  }
}