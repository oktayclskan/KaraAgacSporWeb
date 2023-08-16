using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class News
    {
        public int ID { get; set; }
        public string NewsTitle { get; set; }
        public string NewsDescription { get; set; }
        public string NewsContent { get; set; }
        public DateTime NewsDate { get; set; }
        public string NewsCardImg { get; set; }
        public string NewsContentImg { get; set; }
    }
}
