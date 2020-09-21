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

    public class LeagueDetailed
    {
        public string idLeague { get; set; }
        public object idSoccerXML { get; set; }
        public string idAPIfootball { get; set; }
        public string strSport { get; set; }
        public string strLeague { get; set; }
        public string strLeagueAlternate { get; set; }
        public string strDivision { get; set; }
        public string idCup { get; set; }
        public string strCurrentSeason { get; set; }
        public string intFormedYear { get; set; }
        public string dateFirstEvent { get; set; }
        public string strGender { get; set; }
        public string strCountry { get; set; }
        public string strWebsite { get; set; }
        public string strFacebook { get; set; }
        public string strTwitter { get; set; }
        public string strYoutube { get; set; }
        public string strRSS { get; set; }
        public string strDescriptionEN { get; set; }
        public object strDescriptionDE { get; set; }
        public string strDescriptionFR { get; set; }
        public object strDescriptionIT { get; set; }
        public object strDescriptionCN { get; set; }
        public object strDescriptionJP { get; set; }
        public object strDescriptionRU { get; set; }
        public object strDescriptionES { get; set; }
        public object strDescriptionPT { get; set; }
        public object strDescriptionSE { get; set; }
        public object strDescriptionNL { get; set; }
        public object strDescriptionHU { get; set; }
        public object strDescriptionNO { get; set; }
        public object strDescriptionPL { get; set; }
        public object strDescriptionIL { get; set; }
        public string strFanart1 { get; set; }
        public string strFanart2 { get; set; }
        public string strFanart3 { get; set; }
        public string strFanart4 { get; set; }
        public string strBanner { get; set; }
        public string strBadge { get; set; }
        public string strLogo { get; set; }
        public string strPoster { get; set; }
        public string strTrophy { get; set; }
        public string strNaming { get; set; }
        public string strComplete { get; set; }
        public string strLocked { get; set; }
    }

    public class Leagues
    {
        public List<League> leagues { get; set; }
    }
    public class LeagueD
    {
        public List<LeagueDetailed> leagues { get; set; }
    }

}
