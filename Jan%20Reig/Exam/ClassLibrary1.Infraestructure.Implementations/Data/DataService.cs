using System.Collections.Generic;
using ClassLibrary1.Library.Models;
using Newtonsoft.Json;

namespace ClassLibrary1.Infraestructure.Implementations.Data
{


    public class DataService
    {
        private readonly string _planetsUrl = "https://otd-exams-data.vueling.app/sindicate/planets.json";
        private readonly string _distancesUrl = "https://otd-exams-data.vueling.app/sindicate/distances.json";

        public DataService(string distancesUrl)
        {
            _distancesUrl = distancesUrl;
        }

        public List<Planet> GetPlanets()
        {
            using (var client = new System.Net.WebClient())
            {
                var planetsJson = client.DownloadString(_planetsUrl);
                return JsonConvert.DeserializeObject<List<Planet>>(planetsJson);
            }
        }

        
    }
}
