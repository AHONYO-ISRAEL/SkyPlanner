using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkyPlanner.Models
{
    class Booking
    {
        [PrimaryKey, AutoIncrement]
        public int BookingID { get; set; }



        public int UserID { get; set; }

        public int FlightID { get; set; }

        public DateTime BookingDateTime { get; set; }
        public string SeatNumbers { get; set; }
        public string PaymentStatus { get; set; }
        public string CancellationStatus { get; set; }
    }
}
