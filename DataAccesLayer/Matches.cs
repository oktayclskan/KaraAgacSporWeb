using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class Matches
    {
        public int ID { get; set; }
        public int StadiumID { get; set; }
        public string StadiumName { get; set; }
        public int OpposingTeamID { get; set; }
        public string OpposingTeamName { get; set; }
        public string OppesingTeamLogo { get; set; }
        public int MyTeamScore { get; set; }
        public int OpposingTeamScore { get; set; }
        public bool StadiumOwner { get; set; }
        public string StadiumOwnerStr { get; set; }
        public DateTime MatchDateTime { get; set; }
        public string MatchDateTimeStr { get; set; }
    }
}
