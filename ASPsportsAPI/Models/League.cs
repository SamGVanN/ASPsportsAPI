using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPsportsAPI.Models
{

    public class League
    {
        public string idLeague { get; set; }

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
        [Display(Name = "Sport")]
        public string strSport { get; set; }
        [Display(Name = "League name")]
        public string strLeague { get; set; }
        [Display(Name = "alternative league name")]
        public string strLeagueAlternate { get; set; }
        [Display(Name = "Division")]
        public string strDivision { get; set; }
        [Display(Name = "Cup")]
        public string idCup { get; set; }
        [Display(Name = "Current Season")]
        public string strCurrentSeason { get; set; }
        [Display(Name = "Year of creation")]
        public string intFormedYear { get; set; }
        public string dateFirstEvent { get; set; }
        [Display(Name = "Gender")]
        public string strGender { get; set; }

        [Display(Name = "Country")]
        public string strCountry { get; set; }
        [Display(Name = "Website")]
        public string strWebsite { get; set; }
        [Display(Name = "Facebook")]
        public string strFacebook { get; set; }
        [Display(Name = "Twitter")]
        public string strTwitter { get; set; }
        [Display(Name = "Youtube")]
        public string strYoutube { get; set; }
        [Display(Name = "RSS")]
        public string strRSS { get; set; }

        [Display(Name = "EN Description")]
        public string strDescriptionEN { get; set; }
        [Display(Name = "Description DE")]
        public object strDescriptionDE { get; set; }
        [Display(Name = "Description FR")]
        public string strDescriptionFR { get; set; }
        [Display(Name = "Description IT")]
        public object strDescriptionIT { get; set; }
        [Display(Name = "Description CN")]
        public object strDescriptionCN { get; set; }
        [Display(Name = "Description JP")]
        public object strDescriptionJP { get; set; }
        [Display(Name = "Description RU")]
        public object strDescriptionRU { get; set; }
        [Display(Name = "DescriptionES ")]
        public object strDescriptionES { get; set; }
        [Display(Name = "Description PT")]
        public object strDescriptionPT { get; set; }
        [Display(Name = "Description SE")]
        public object strDescriptionSE { get; set; }
        [Display(Name = "Description NL")]
        public object strDescriptionNL { get; set; }
        [Display(Name = "Description HU")]
        public object strDescriptionHU { get; set; }
        [Display(Name = "Description NO")]
        public object strDescriptionNO { get; set; }
        [Display(Name = "DescriptionPL ")]
        public object strDescriptionPL { get; set; }
        [Display(Name = "Description IL")]
        public object strDescriptionIL { get; set; }

        [Display(Name = "Fanart")]
        public string strFanart1 { get; set; }
        [Display(Name = "Fanart")]
        public string strFanart2 { get; set; }
        [Display(Name = "Fanart")]
        public string strFanart3 { get; set; }
        [Display(Name = "Fanart")]
        public string strFanart4 { get; set; }
        [Display(Name = "Banner")]
        public string strBanner { get; set; }
        [Display(Name = "Badge")]
        public string strBadge { get; set; }

        [Display(Name = "Logo")]
        public string strLogo { get; set; }

        [Display(Name = "Poster")]
        public string strPoster { get; set; }

        [Display(Name = "Trophy")]
        public string strTrophy { get; set; }

        [Display(Name = "Naming")]
        public string strNaming { get; set; }
        public string strComplete { get; set; }
        public string strLocked { get; set; }
    }

    public class Leagues
    {
        [Display(Name = "Leagues")]
        public List<League> leagues { get; set; }
    }
    public class LeagueDetails
    {
        [Display(Name = "Leagues in detail")]
        public List<LeagueDetailed> leagues { get; set; }
    }

}
