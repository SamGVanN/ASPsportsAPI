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
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(json);
           
            model = myDeserializedClass.leagues;

            return View(model);


    }

}
}
