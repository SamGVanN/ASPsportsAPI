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
        const string url = "https://www.thesportsdb.com/api/v1/json/1/";

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LeagueTeams(string leagueName)
        {

            var model = new List<Team>();
            HttpClient httpClient = new HttpClient()
            {
                BaseAddress = new Uri(url)
            };
            var json = httpClient.GetStringAsync("search_all_teams.php?l=" + leagueName).Result;
            Teams myDeserializedClass = JsonConvert.DeserializeObject<Teams>(json);

            model = myDeserializedClass.teams;

            return View(model);

        }

        public IActionResult TeamDetails(string idTeam)
        {
            var model = new Team();
            HttpClient httpClient = new HttpClient()
            {
                BaseAddress = new Uri(url)
            };
            var json = httpClient.GetStringAsync("lookupteam.php?id=" + idTeam).Result;
            Teams myDeserializedClass = JsonConvert.DeserializeObject<Teams>(json);

            model = myDeserializedClass.teams.FirstOrDefault();
            if (!model.strYoutube.StartsWith("http://"))
            {
                model.strYoutube = "http://" + model.strYoutube;
            }

            return View(model);
        }
        


        public IActionResult Leagues()
        {
            var model = new List<League>();

            
            HttpClient httpClient = new HttpClient()
            {
                BaseAddress = new Uri(url)
            };

            var json = httpClient.GetStringAsync("all_leagues.php?s=Soccer").Result;
            Leagues myDeserializedClass = JsonConvert.DeserializeObject<Leagues>(json);

            model = myDeserializedClass.leagues;

            return View(model);


        }

        [HttpGet]
        public IActionResult LeagueInformations(string leagueId)
        {
            var model = new LeagueDetailed();

            HttpClient httpClient = new HttpClient()
            {
                BaseAddress = new Uri(url)
            };

            var json = httpClient.GetStringAsync("lookupleague.php?id="+leagueId).Result;
            LeagueD myDeserializedClass = JsonConvert.DeserializeObject<LeagueD>(json);

            model = myDeserializedClass.leagues.FirstOrDefault();

            return View(model);

        }

    }
}
