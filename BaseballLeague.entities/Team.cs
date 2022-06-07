using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballLeague.entities
{
    public class Team
    {
        public GUid TeamId { get; set; }
        public string UserName { get; set; }
        public string TeamDescription { get; set; }

    }
}
