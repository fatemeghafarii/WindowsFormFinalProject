using Library.Persistence.ConnectionStrings;
using Library.Persistence.IRepositories;
using System.Data;
using System.Data.SqlClient;

namespace Library.Persistence.Repositories
{
    public class CityRepository : ReadRepository, ICityRepository
    {
        private readonly SqlConnection sqlConnection;

        public CityRepository()
        {
            sqlConnection = new SqlConnection(ConnectionString.LibararyConnectionString);
        }

        //public DataTable Get(string procName)
        //{
        //    DataTable dt = new DataTable();

        //    SqlCommand query = new SqlCommand(procName, sqlConnection);
        //    query.CommandType = CommandType.StoredProcedure;

        //    sqlConnection.Open();

        //    dt.Load(query.ExecuteReader());

        //    sqlConnection.Close();

        //    return dt;
        //}
    }
}
