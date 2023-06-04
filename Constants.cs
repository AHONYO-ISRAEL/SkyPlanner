

namespace SkyPlanner
{
    public static class Constants
    {
        public const string DatabaseFilename = "SkyPlannerDB.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            //Database opened in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            //created if not exist
            SQLite.SQLiteOpenFlags.Create |
            //multi-thread access to database enabled
            SQLite.SQLiteOpenFlags.SharedCache;


        public static string DatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);
            
    }
}
