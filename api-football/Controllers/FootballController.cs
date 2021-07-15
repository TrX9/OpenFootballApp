using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_football.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FootballController : ControllerBase
    {
        [HttpGet]
        [Route("GetData/{country}")]
        public IEnumerable<Football> Get([FromRoute] string country)
        {
            List<Football> lstObj = new List<Football>();
            var client = new RestClient("https://v3.football.api-sports.io/teams?country="+ country);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "f2e4f1da0f6dfa8edd21e88f6543e020");
            request.AddHeader("x-rapidapi-host", "v3.football.api-sports.io");
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {
                Root responseObj = JsonConvert.DeserializeObject<Root>(response.Content);
                if (responseObj != null && responseObj.response != null && responseObj.response.Count > 0)
                {
                    foreach (var item in responseObj.response)
                    {
                        Football obj = new Football();
                        obj.city = item.venue.city;
                        obj.founded = item.team.founded;
                        obj.name = item.team.name;
                        obj.venueName = item.venue.name;
                        obj.logo = item.team.logo;
                        lstObj.Add(obj);
                    }
                }
            }

            return lstObj;
        }
    }
}
