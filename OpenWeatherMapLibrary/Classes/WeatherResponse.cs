namespace OpenWeatherMapLibrary.Classes
{
  public class WeatherResponse
  {
    public string Base { get; set; }
    public int Visibility { get; set; }
    public uint Dt { get; set; }
    public int Timezone { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public int Cod { get; set; }
    public Coordinates Coord { get; set; }
    public IEnumerable<WeatherCondition> Weather { get; set; }
    public MainWeather Main { get; set; }
    public WindCondition Wind { get; set; }
    public CloudsCondition Clouds { get; set; }
    public VolumeByTimeCondition Rain { get; set; }
    public VolumeByTimeCondition Snow { get; set; }
    public InternalMetadata Sys { get; set; }
  }
}