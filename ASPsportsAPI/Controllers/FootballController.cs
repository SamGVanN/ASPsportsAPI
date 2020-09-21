using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ASPsportsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ASPsportsAPI.Controllers
{
    public class FootballController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult League()
        {
            return View();
        }


        public IActionResult Leagues()
        {
            var model = new List<League>();

            const string url = "https://www.thesportsdb.com/api/";
            HttpClient httpClient = new HttpClient()
            {
                BaseAddress = new Uri(url)
            };

            var json = httpClient.GetStringAsync("v1/json/1/all_leagues.php?s=Soccer").Result;
            Leagues myDeserializedClass = JsonConvert.DeserializeObject<Leagues>(json);

            model = myDeserializedClass.leagues;

            return View(model);


        }

        [HttpGet]
        public IActionResult LeagueInformations(string leagueId)
        {
            var model = new LeagueDetailed();

            const string url = "https://www.thesportsdb.com/api/";
            HttpClient httpClient = new HttpClient()
            {
                BaseAddress = new Uri(url)
            };

            var json = httpClient.GetStringAsync("v1/json/1/lookupleague.php?id="+leagueId).Result;
            LeagueD myDeserializedClass = JsonConvert.DeserializeObject<LeagueD>(json);

            model = myDeserializedClass.leagues.FirstOrDefault();

            return View(model);

        }

    }
}
