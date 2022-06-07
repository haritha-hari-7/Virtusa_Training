using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballLeague.entities
{
    public class Referee
    {
        public Guid RefereeId { get; set; }
        public string RefereeName { get; set; }
        public int NoOfMatches { get; set; }
    }
}
