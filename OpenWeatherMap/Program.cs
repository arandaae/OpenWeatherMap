using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace OpenWeatherMap
{
    public class Program
    {        
        static void Main(string[] args)
        {
            var client = new HttpClient();    
            
            //var city = "Franklin";
            
            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q=Franklin&appid=0872c0538dc0a5c1fafa52d0866377a9&units=imperial";           
            var response = client.GetStringAsync(weatherURL).Result;        
            var formattedResponse = JObject.Parse(response).GetValue("main").ToString();

            //JObject formattedResponse = JObject.Parse(response);
            //var temp = formattedResponse["list"][0]["main"]["temp"];
            //Console.WriteLine(temp);
            
            Console.WriteLine($"Franklin, WI weather: {JObject.Parse(formattedResponse).GetValue("temp")} degrees fahrenheit");
        }
    }
}
