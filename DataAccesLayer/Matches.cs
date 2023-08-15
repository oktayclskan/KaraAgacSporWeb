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
        public string MyTeam  { get; set; }
        public int OppossingTeamID { get; set; }
        public string OppossingTeamName { get; set; }
        public int MyTeamScore { get; set; }
        public int OpposingTeamScore { get; set; }
        public bool StadiumOwner { get; set; }
        public string StadiumOwnerStr { get; set; }
        public string ImgOne { get; set; }
        public string ImgTwo { get; set; }
        public string ImgThree { get; set; }
        public string ImgFour { get; set; }
        public string ImgFive { get; set; }
        public DateTime MatchDateTime { get; set; }
    }
}
