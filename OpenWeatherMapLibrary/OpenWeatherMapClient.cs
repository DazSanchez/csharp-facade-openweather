using OpenWeatherMapLibrary.Classes;
using System.Collections.Specialized;
using System.Text.Json;
using System.Web;

namespace OpenWeatherMapLibrary
{
  public class OpenWeatherMapClient
  {
    private readonly HttpClient http;
    private readonly string apiKey;
    private readonly Uri endpoint;

    public OpenWeatherMapClient(string apiKey) : this(apiKey, "2.5") { }
    public OpenWeatherMapClient(string apiKey, string apiVersion)
    {
      this.apiKey = apiKey;
      this.endpoint = new Uri($"https://api.openweathermap.org/data/{apiVersion}/weather");
      this.http = new HttpClient();
    }

    public async Task<WeatherResponse> GetWeatherByCity(string city)
    {
      var query = HttpUtility.ParseQueryString(String.Empty);
      query["q"] = city;

      return await MakeRequest(query);
    }

    public async Task<WeatherResponse> GetWeatherByGeolocation(double lat, double lon)
    {
      var query = HttpUtility.ParseQueryString(String.Empty);
      query["lat"] = lat.ToString();
      query["lon"] = lon.ToString();

      return await MakeRequest(query);
    }

    private async Task<WeatherResponse> MakeRequest(NameValueCollection query)
    {
      try
      {
        var builder = new UriBuilder(this.endpoint);
        query["appid"] = this.apiKey;
        builder.Query = query.ToString();

        var streamResponse = await this.http.GetStreamAsync(builder.ToString());
        var response = await JsonSerializer.DeserializeAsync<WeatherResponse>(streamResponse);
        return response;
      }
      catch (HttpRequestException e)
      {
        throw new Exception(e.Message);
      }
    }
  }

}