using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballLeague.entities
{
    public class User
    {
        public Guid email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int MobileNumber { get; set; }
        public string UserRole { get; set; }

    }
}
