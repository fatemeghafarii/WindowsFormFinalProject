using Library.Model.Models;
using Library.Persistence.ConnectionStrings;
using Library.Persistence.IRepositories;
using System.Data;
using System.Data.SqlClient;

namespace Library.Persistence.Repositories
{
    public class AirlineRepository : ReadRepository, IAirlineRepository
    {
        private readonly SqlConnection sqlConnection;
        public AirlineRepository()
        {
            sqlConnection = new SqlConnection(ConnectionString.LibararyConnectionString);
        }

        public int Add(Airline airline)
        {
            var sqlCommand = new SqlCommand("Usp_Airline_AddLogoImageAirlines", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@LogoImage", airline.Image);

            sqlConnection.Open();

            int result = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return result;
        }
    }
}
