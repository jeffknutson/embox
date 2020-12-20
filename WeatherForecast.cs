using System;

namespace embox
{
  public class WeatherForecast
  {
    public WeatherForecast()
    {
      Pancakes = new Random().Next();
    }

    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string Summary { get; set; }

    public int Pancakes
    {
      get; set;
    }
  }
}
