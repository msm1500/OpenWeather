using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Web.Script.Serialization;

namespace OpenWeather
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetWeatherInfo(object sender, EventArgs e)
        {
            string appid = "de6d52c2ebb7b1398526329875a49c57";
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&units=metric&cnt=1&APPID={1}", txtCity.Text, appid);
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                WeatherInfo weatherInfo = (new JavaScriptSerializer()).Deserialize<WeatherInfo>(json);
                lblCity_Country.Text = weatherInfo.city.name + ", " + weatherInfo.city.country;
                lblDescription.Text = weatherInfo.list[0].weather[0].description;
                lblTempMin.Text = string.Format("{0}.c", Math.Round(weatherInfo.list[0].temp.min, 1));
                lblTempMax.Text = string.Format("{0}.c", Math.Round(weatherInfo.list[0].temp.max, 1));
                lblTempDay.Text = string.Format("{0}.c", Math.Round(weatherInfo.list[0].temp.day, 1));
                lblTempNight.Text = string.Format("{0}.c", Math.Round(weatherInfo.list[0].temp.night, 1));
                lblHumidity.Text = weatherInfo.list[0].humidity.ToString();
                //lblTimeSunrise.Text = ;
                tblWeather.Visible = true;

            }
        }

        public class WeatherInfo
        {
            public City city { get; set; }
            public List<List> list { get; set; }
        }

        public class City
        {
            public string name { get; set; }
            public string country { get; set; }

        }

        public class Temp
        {
            public double day { get; set; }
            public double min { get; set; }
            public double max { get; set; }
            public double night { get; set; }
        }
        public class Weather
        {
            public string description { get; set; }

        }
        public class List
        {
            public Temp temp { get; set; }
            public int humidity { get; set; }
            public List<Weather> weather { get; set; }
        }
        public class Sys
        {
            public string country { get; set; }
            public int sunrise { get; set; }
            public int sunset { get; set; }
        }
    }
}