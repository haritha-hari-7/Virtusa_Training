using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballLeague.entities
{
    public class Event
    {
        public Guid EventId { get; set; }
        public string EventName { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantAddress { get; set; }
        public int ApplicantMobile { get; set; }
        public string ApplicantEmail { get; set; }
        public string EventAddress { get; set; }
        public string EventFromDate { get; set; }
        public string EventToDate { get; set; }
    }
}
