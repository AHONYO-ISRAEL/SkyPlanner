using SQLite;


namespace SkyPlanner.Models
{
    class Flight
    {
        [PrimaryKey, AutoIncrement]
        public int FlightID { get; set; }

        public string Airline { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public decimal Price { get; set; }
        public int AvailableSeats { get; set; }
        public string FlightType { get; set; }
    }
}
