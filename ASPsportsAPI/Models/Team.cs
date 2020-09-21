using System;
using System.Collections.Generic;
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
        public string strTeam { get; set; }
        public object strTeamShort { get; set; }
        public string strAlternate { get; set; }
        public string intFormedYear { get; set; }
        public string strSport { get; set; }
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
        public object strDivision { get; set; }
        public string strManager { get; set; }
        public string strStadium { get; set; }
        public string strKeywords { get; set; }
        public string strRSS { get; set; }
        public object strStadiumThumb { get; set; }
        public object strStadiumDescription { get; set; }
        public string strStadiumLocation { get; set; }
        public string intStadiumCapacity { get; set; }
        public string strWebsite { get; set; }
        public string strFacebook { get; set; }
        public string strTwitter { get; set; }
        public string strInstagram { get; set; }
        public string strDescriptionEN { get; set; }
        public object strDescriptionDE { get; set; }
        public object strDescriptionFR { get; set; }
        public object strDescriptionCN { get; set; }
        public object strDescriptionIT { get; set; }
        public object strDescriptionJP { get; set; }
        public object strDescriptionRU { get; set; }
        public object strDescriptionES { get; set; }
        public object strDescriptionPT { get; set; }
        public object strDescriptionSE { get; set; }
        public object strDescriptionNL { get; set; }
        public object strDescriptionHU { get; set; }
        public object strDescriptionNO { get; set; }
        public object strDescriptionIL { get; set; }
        public object strDescriptionPL { get; set; }
        public string strGender { get; set; }
        public string strCountry { get; set; }
        public string strTeamBadge { get; set; }
        public object strTeamJersey { get; set; }
        public object strTeamLogo { get; set; }
        public object strTeamFanart1 { get; set; }
        public object strTeamFanart2 { get; set; }
        public object strTeamFanart3 { get; set; }
        public object strTeamFanart4 { get; set; }
        public object strTeamBanner { get; set; }
        public string strYoutube { get; set; }
        public string strLocked { get; set; }
    }

    public class Teams
    {
        public List<Team> teams { get; set; }
    }


}
