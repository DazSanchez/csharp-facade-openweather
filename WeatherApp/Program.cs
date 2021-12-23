using System.Diagnostics;
using OpenWeatherMapLibrary;

namespace WeatherApp
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
      try
      {
        if (args.Length < 1)
        {
          Console.Error.WriteLine("Missing required argument(s)");
        }
        else if (args.Length == 1)
        {
          Console.Error.WriteLine(String.Join(Environment.NewLine,
            new string[] {
            "Weather App 1.0",
            "WeatherApp <api_key> <city_name>    Gets the current weather by city name.",
            "WeatherApp <api_key> <lat> <long>   Gets the current weather by coordinates.",
            "WeatherApp --help         Shows this message."
            }));
          Environment.Exit(0);
        }
        else if (args.Length == 2)
        {
          var apiKey = args[0];
          var city = args[1];

          OpenWeatherMapClient client = new OpenWeatherMapClient(apiKey);

          var weather = await client.GetWeatherByCity(city);
          Console.WriteLine(weather);
        }
        else if (args.Length == 3)
        {
          var apiKey = args[0];
          var lat = Double.Parse(args[0]);
          var lon = Double.Parse(args[1]);

          OpenWeatherMapClient client = new OpenWeatherMapClient(apiKey);

          var weather = await client.GetWeatherByGeolocation(lat, lon);
          Console.WriteLine(weather);
        }
        else
        {
          Console.Error.WriteLine("Invalid arguments provided.");
        }
      }
      catch (Exception e)
      {
        Console.Error.WriteLine(e.Message);
      }
    }
  }
}