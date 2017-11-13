using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightAlert
{
    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public double pressure { get; set; }
        public double sea_level { get; set; }
        public double grnd_level { get; set; }
        public int humidity { get; set; }
        public double temp_kf { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Clouds
    {
        public int all { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
        public double deg { get; set; }
    }

    public class Sys
    {
        public string pod { get; set; }
    }

    public class List
    {
        public int dt { get; set; }
        public Main main { get; set; }
        public List<Weather> weather { get; set; }
        public Clouds clouds { get; set; }
        public Wind wind { get; set; }
        public Sys sys { get; set; }
        public string dt_txt { get; set; }
    }

    public class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public Coord coord { get; set; }
        public string country { get; set; }
        public string cod { get; set; }
        public double message { get; set; }
        public int cnt { get; set; }
        public List<List> list { get; set; }
    }

    public class RootObject
    {
        public City city { get; set; }
    }

    static class Program
    {
        static HttpClient client = new HttpClient();

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            RunAsync().Wait();
        }

        static async Task<RootObject> GetProductAsync(string path)
        {
            RootObject product = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<RootObject>();
            }
            return product;
        }

        static async Task RunAsync()
        {
            //api call here
            // api.openweathermap.org/data/2.5/forecast?q=58103&APPID=28cab4ebdf5237245ef401e8fa51a7f4
            // call options
            // OR ?q={city name},{country code}
            // OR ?id={city ID}
            // OR ?lat={lat}&lon={lon}
            // OR ?zip ={ zip code},{ country code}
            client.BaseAddress = new Uri("api.openweathermap.org/data/2.5/forecast?q=58103&APPID=28cab4ebdf5237245ef401e8fa51a7f4");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Console.ReadLine();
        }
    }
}
