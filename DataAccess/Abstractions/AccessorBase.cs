using Dapper;
using DataAccess.Factories;
using System.Data.SqlClient;
using WetEntryKayak.DatabaseAccess.Factories;

namespace WetEntryKayak.DatabaseAccess
{
    internal abstract class AccessorBase
    {
        private readonly string connectionString;
        internal AccessorBase()
        {
            connectionString = SqlConnectionStringFactory.Execute();
        }
        public void Create<T>(T target)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string targetSProc = SProcFactory.RetrieveCreateSProcName<T>();
                object parameters = ConvertToDataTable(target);
                connection.Execute(targetSProc, parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
