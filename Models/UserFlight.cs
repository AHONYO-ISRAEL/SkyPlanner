using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyPlanner.Models
{

    public class UserFlight
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FromCity { get; set; }
        public string ToCity { get; set; }
        public DateTime FlightDate { get; set; }

    }
}
