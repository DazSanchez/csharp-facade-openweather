using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenWeatherMapLibrary.Classes
{
  public class APIException : Exception
  {
    public APIException(short cod, string message) : base(message)
    {
      this.Cod = cod;
    }

    [JsonPropertyName("cod")]
    public short Cod { get; }
    [JsonPropertyName("message")]
    public override string Message { get; }

    public override string ToString()
    {
      return JsonSerializer.Serialize(this);
    }
  }
}