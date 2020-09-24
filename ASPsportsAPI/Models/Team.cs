using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPsportsAPI.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Team
    {
        public string idTeam { get; set; }
        public object idSoccerXML { get; set; }
        public string idAPIfootball { get; set; }
        public object intLoved { get; set; }

        [Display(Name = "Team name")]
        public string strTeam { get; set; }
        [Display(Name = "Team short name")]
        public object strTeamShort { get; set; }
        [Display(Name = "Team alternative name")]
        public string strAlternate { get; set; }
        [Display(Name = "Year of creation")]
        public string intFormedYear { get; set; }
        [Display(Name = "Sport category")]
        public string strSport { get; set; }
        [Display(Name = "League")]
        public string strLeague { get; set; }
        public string idLeague { get; set; }
        public object strLeague2 { get; set; }
        public object idLeague2 { get; set; }
        public object strLeague3 { get; set; }
        public object idLeague3 { get; set; }
        public object strLeague4 { get; set; }
        public object idLeague4 { get; set; }
        public object strLeague5 { get; set; }
        public object idLeague5 { get; set; }
        public object strLeague6 { get; set; }
        public object idLeague6 { get; set; }
        public object strLeague7 { get; set; }
        public object idLeague7 { get; set; }
        [Display(Name = "Division")]
        public object strDivision { get; set; }
        [Display(Name = "Manager")]
        public string strManager { get; set; }
        [Display(Name = "Stadium")]
        public string strStadium { get; set; }
        [Display(Name = "Keywords")]
        public string strKeywords { get; set; }
        [Display(Name = "RSS")]
        public string strRSS { get; set; }
        [Display(Name = "Stadium thumb")]
        public object strStadiumThumb { get; set; }
        [Display(Name = "Stadium Description")]
        public object strStadiumDescription { get; set; }
        [Display(Name = "Stadium Location")]
        public string strStadiumLocation { get; set; }
        [Display(Name = "Stadium Capacity")]
        public string intStadiumCapacity { get; set; }
        [Display(Name = "Website")]
        public string strWebsite { get; set; }
        [Display(Name = "Facebook")]
        public string strFacebook { get; set; }
        [Display(Name = "Twitter")]
        public string strTwitter { get; set; }

        [Display(Name = "Instagram")]
        public string strInstagram { get; set; }

        [Display(Name = "English Description")]
        public string strDescriptionEN { get; set; }
        [Display(Name = "DE Description")]
        public object strDescriptionDE { get; set; }
        [Display(Name = "French Description")]
        public object strDescriptionFR { get; set; }
        [Display(Name = "CN Description")]
        public object strDescriptionCN { get; set; }
        [Display(Name = "Italian Description")]
        public object strDescriptionIT { get; set; }
        [Display(Name = "Japanese Description")]
        public object strDescriptionJP { get; set; }
        [Display(Name = "Russian Description")]
        public object strDescriptionRU { get; set; }
        [Display(Name = "Spanish Description")]
        public object strDescriptionES { get; set; }
        [Display(Name = "Portuguese Description")]
        public object strDescriptionPT { get; set; }
        [Display(Name = "Description SE")]
        public object strDescriptionSE { get; set; }
        [Display(Name = "Description NL")]
        public object strDescriptionNL { get; set; }
        [Display(Name = "Description HU")]
        public object strDescriptionHU { get; set; }
        [Display(Name = "Description NO")]
        public object strDescriptionNO { get; set; }
        [Display(Name = "Description IL")]
        public object strDescriptionIL { get; set; }
        [Display(Name = "Description PL")]
        public object strDescriptionPL { get; set; }
        [Display(Name = "Gender")]
        public string strGender { get; set; }
        [Display(Name = "Country")]
        public string strCountry { get; set; }
        [Display(Name = "Bagde")]
        public string strTeamBadge { get; set; }
        [Display(Name = "Jersey")]
        public object strTeamJersey { get; set; }
        [Display(Name = "Logo")]
        public object strTeamLogo { get; set; }
        [Display(Name = "Fanart")]
        public object strTeamFanart1 { get; set; }
        [Display(Name = "Fanart")]
        public object strTeamFanart2 { get; set; }
        [Display(Name = "Fanart")]
        public object strTeamFanart3 { get; set; }
        [Display(Name = "Fanart")]
        public object strTeamFanart4 { get; set; }
        [Display(Name = "Team banner")]
        public object strTeamBanner { get; set; }

        [Display(Name = "Youtube")]
        public string strYoutube { get; set; }
        public string strLocked { get; set; }
    }

    public class Teams
    {
        [Display(Name = "Teams")]
        public List<Team> teams { get; set; }
    }


}
