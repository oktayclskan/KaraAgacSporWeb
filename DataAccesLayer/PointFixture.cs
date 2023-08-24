using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class PointFixture
    {
        public int ID { get; set; }
        public int OpposingTeamID { get; set; }
        public string OpposingTeamName { get; set; }
        public int Win { get; set; }
        public int Draw { get; set; }
        public int Lose { get; set; }
        public int Point { get; set; }
    }
}
