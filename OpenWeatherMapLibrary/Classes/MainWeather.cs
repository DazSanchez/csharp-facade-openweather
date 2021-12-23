namespace OpenWeatherMapLibrary.Classes
{
  public class MainWeather
  {
    public float Temp { get; set; }
    public float FeelsLike { get; set; }
    public float TempMin { get; set; }
    public float TempMax { get; set; }
    public short Pressure { get; set; }
    public byte Humidity { get; set; }
    public short SeaLevel { get; set; }
    public short GrndLevel { get; set; }
  }
}