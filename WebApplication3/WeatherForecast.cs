namespace WebApplication3
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 35 + (int)(TemperatureC / 0.5557);

        public string? Summary { get; set; }
    }
}
