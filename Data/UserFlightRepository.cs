using SkyPlanner.Models;
using SQLite;

namespace SkyPlanner.Data
{
    internal class UserFlightRepository
    {
        string _dbPath;
        private SQLiteConnection conn;

        public UserFlightRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<UserFlight>();
        }
        public List<UserFlight> GetAllFlights()
        {
            Init();
            return conn.Table<UserFlight>().ToList();
        }

        public void Add(UserFlight userFlight)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Insert(userFlight);

        }

        public void Delete(int Id)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Delete(new { Id = Id});
        }

    }
}
