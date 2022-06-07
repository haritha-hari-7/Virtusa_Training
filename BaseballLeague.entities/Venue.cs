using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballLeague.entities
{
    public class Venue
    {
        public Guid VenueId { get; set; }
        public string VenueName { get; set; }
        public string VenueImageUrl { get; set; }
        public string VenueDescription { get; set; }
        public string VenueLocation { get; set; }

    }
}
