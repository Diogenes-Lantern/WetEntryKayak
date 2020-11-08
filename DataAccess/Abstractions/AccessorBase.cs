using Dapper;
using DataAccess.Factories;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

        internal void Create<T>(T target)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string targetSProc = SProcFactory.RetrieveCreateSProcName<T>();
                object parameters = ConvertToDataTable(target);
                connection.Execute(targetSProc, parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        internal List<U> Retrieve<T, U>(T target)
        {
            List<U> result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string targetSProc = SProcFactory.RetrieveRetrievalSProcName<T>();
                object parameters = ConvertToDataTable(target);
                result = connection.Query<U>(targetSProc, parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
            return result;
        }
    }
}
