using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPsportsAPI.Models
{


    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class League
    {
        public int idLeague { get; set; }
        [Display(Name = "League Name")]
        public string strLeague { get; set; }

        [Display(Name = "Sport")]
        public string strSport { get; set; }

        [Display(Name = "Also known as")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "No other known name")]
        public string strLeagueAlternate { get; set; }
    }

    public class Root
    {
        public List<League> leagues { get; set; }
    }


    //public class League
    //{
    //    public int idLeague;

    //    [Display(Name = "League Name")]
    //    public string strLeague;

    //    public string strSport;

    //    [Display(Name = "Also known as")]
    //    public string strLeagueAlternate;

    //}
}
