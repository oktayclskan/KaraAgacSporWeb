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
        public int PlayerID { get; set; }
        public int CardID { get; set; }
        public string Time { get; set; }
    }
}
