using System.Text.Json.Serialization;

namespace OpenWeatherMapLibrary.Classes
{
  public class VolumeByTimeCondition
  {
    [JsonPropertyName("1h")]
    public short OneHour { get; set; }
    [JsonPropertyName("3h")]
    public short ThreeHours { get; set; }
  }
}