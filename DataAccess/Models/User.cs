namespace DataAccess.Models
{
    internal class User
    {
        public int UserID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
