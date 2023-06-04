using SQLite;


namespace SkyPlanner.Models
{
    [Table("User")]
    class User
    {
        [PrimaryKey, AutoIncrement]
        public int UserID { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

       

    }
}
