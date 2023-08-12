using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class Players
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UniformNumber { get; set; }
        public string Position { get; set; }
        public bool FirstEleven { get; set; }
        public bool StatusPlayer { get; set; }
    }
}
