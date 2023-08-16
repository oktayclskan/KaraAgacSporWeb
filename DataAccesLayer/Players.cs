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
        public string PlayerName { get; set; }
        public string PlayerSurname { get; set; }
        public DateTime PlayerDateOfBirth { get; set; }
        public string PlayerDateOfBirthStr { get; set; }
        public string PlayerUniformNumber { get; set; }
        public string PlayerPosition { get; set; }
        public bool PlayerFirstEleven { get; set; }
        public string PlayerFirstElevenStr { get; set; }
        public bool PlayerStatusPlayer { get; set; }
        public string PlayerStatusPlayerStr { get; set; }
        public string PlayerImg { get; set; }
    }
}
