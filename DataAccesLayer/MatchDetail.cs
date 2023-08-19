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
        public int MatchID { get; set; }
        public string MatchName { get; set; }
        public int PlayerID { get; set; }
        public string OpposingPlayer { get; set; }
        public string PlayerName { get; set; }
        public bool MyTeamGoal { get; set; }
        public bool OpposingGoal { get; set; }
        public int MyTeamCardID { get; set; }
        public int OpposingCardID { get; set; }
        public string MyTeamCard { get; set; }
        public string OpposingCard { get; set; }
        public string MatchDetailTime { get; set; }
    }
}
