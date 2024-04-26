using ASPsportsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;

namespace ASPsportsAPI.Controllers
{
    public class FootballController : Controller
    {
        const string url = "https://www.thesportsdb.com/api/v1/json/3/";

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Leagues()
        {
            var model = new List<League>();

            
            HttpClient httpClient = new HttpClient()
            {
                BaseAddress = new Uri(url)
            };

            var json = httpClient.GetStringAsync("all_leagues.php?s=Soccer").Result;
            Leagues myDeserializedClass = JsonSerializer.Deserialize<ASPsportsAPI.Models.Leagues>(json);

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
            LeagueDetails myDeserializedClass = JsonSerializer.Deserialize<LeagueDetails>(json);

            model = myDeserializedClass.leagues.FirstOrDefault();

            return View(model);

        }

        public IActionResult LeagueTeams(string leagueName)
        {

            var model = new List<Team>();
            HttpClient httpClient = new HttpClient()
            {
                BaseAddress = new Uri(url)
            };
            var json = httpClient.GetStringAsync("search_all_teams.php?l=" + leagueName).Result;
            Teams myDeserializedClass = JsonSerializer.Deserialize<Teams>(json);

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
            Teams myDeserializedClass = JsonSerializer.Deserialize<Teams>(json);

            model = myDeserializedClass.teams.FirstOrDefault();
            if (!model.strYoutube.StartsWith("http://"))
            {
                model.strYoutube = "http://" + model.strYoutube;
            }

            return View(model);
        }

    }
}
