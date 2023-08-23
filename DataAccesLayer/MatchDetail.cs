using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class MatchDetail
    {
        public int ID { get; set; }
        public int CardID { get; set; }
        public string CardName { get; set; }
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public bool MyTeamGoal { get; set; }
        public string MyTeamGoalStr { get; set; }
        public string MyTeamTime{ get; set; }
        public string OpposingTeamPlayerName{ get; set; }
        public bool OpposingTeamGoal { get; set; }
        public string OpposingTeamGoalStr { get; set; }     
        public string OpposingTeamTime { get; set; }
    }
}
