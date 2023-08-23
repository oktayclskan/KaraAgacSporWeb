using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class NextMatch
    {
        public int ID { get; set; }
        public int OpposingTeamID { get; set; }
        public string OpposingTeam { get; set; }
        public int StadiumID { get; set; }
        public string Stadium { get; set; }
        public DateTime Date { get; set; }
    }
}
