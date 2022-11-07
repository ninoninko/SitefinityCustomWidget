using System;
using System.Web;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SpaceXWidget.Mvc.ViewModels;

namespace SpaceXWidget.Mvc.Models
{
    public class FlightDataModel
    {
        public List<string[]> GetViewModel() => Task.Run(() => this.GetLaunchAsync()).Result;

        private async Task<List<string[]>> GetLaunchAsync()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://api.spacexdata.com/v4/launches");
                response.EnsureSuccessStatusCode();
                var jsonString = await response.Content.ReadAsStringAsync();

                var deserializedList = JsonConvert.DeserializeObject<List<LaunchViewModel>>(jsonString);

                List <string[]> aircraftInformation = new List<string[]>();

                foreach (var objectInList in deserializedList)
                {
                    string[] information = new string[2];
                    information[0] = objectInList.Id;
                    information[1] = objectInList.Name;
                    aircraftInformation.Add(information);
                }

                return aircraftInformation;
            }
        }
    }
}