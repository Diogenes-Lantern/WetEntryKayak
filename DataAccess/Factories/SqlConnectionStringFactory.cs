using System.Data.SqlClient;

namespace WetEntryKayak.DatabaseAccess.Factories
{
    internal static class SqlConnectionStringFactory
    {
        internal static string Execute()
        {
            SqlConnectionStringBuilder stringbuilder = new SqlConnectionStringBuilder
            {
                DataSource = "essql1.walton.uark.edu",
                UserID = "PROJECTF2027",
                Password = "SH93ack$",
                InitialCatalog = "PROJECTF2027"
            };
            return stringbuilder.ConnectionString;
        }
    }
}
