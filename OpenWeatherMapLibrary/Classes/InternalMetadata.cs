namespace OpenWeatherMapLibrary.Classes
{
  public class InternalMetadata
  {
    public byte Type { get; set; }
    public short Id { get; set; }
    public string Message { get; set; }
    public string Country { get; set; }
    public int Sunrise { get; set; }
    public int Sunset { get; set; }
  }
}