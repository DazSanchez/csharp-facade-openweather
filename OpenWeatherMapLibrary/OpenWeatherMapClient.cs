using OpenWeatherMapLibrary.Classes;
using System.Net.Http;
using System.Net.Http.Json;
using System.Web;

namespace OpenWeatherMapLibrary
{
  public class OpenWeatherMapClient
  {
    // key = c071e0cfcfda422ae9811ced47ed4e4c
    private readonly HttpClient http;
    private string apiKey;

    public OpenWeatherMapClient(string apiKey) : this(apiKey, "2.5") { }
    public OpenWeatherMapClient(string apiKey, string apiVersion)
    {
      this.apiKey = apiKey;
      this.http = new HttpClient
      {
        BaseAddress = new Uri($"api.openweathermap.org/data/{apiVersion}"),
      };
    }

    public async Task<WeatherResponse> GetWeatherByCity(string city)
    {
      try
      {
        UriBuilder builder = new UriBuilder("/weather");

        var query = HttpUtility.ParseQueryString(builder.Query);
        query["q"] = city;

        builder.Query = query.ToString();

        return await this.http.GetFromJsonAsync<WeatherResponse>(builder.ToString());
      }
      catch (HttpRequestException e)
      {
        throw new Exception(e.Message);
      }
    }

    public Task GetWeatherByGeolocation(double lat, double lon)
    {
      throw new NotImplementedException("Not implemented");
    }


  }

}