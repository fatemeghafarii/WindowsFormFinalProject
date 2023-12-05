using Library.Persistence.ConnectionStrings;
using Library.Persistence.IRepositories;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace Library.Persistence.Repositories
{
    public class ReadRepository : IReadRepository
    {
        private readonly SqlConnection sqlConnection;
        private readonly PersianCalendar persianCalendar;
        public ReadRepository()
        {
            sqlConnection = new SqlConnection(ConnectionString.LibararyConnectionString);
            persianCalendar = new PersianCalendar();
        }

        public DataTable Get(string procName)
        {
            DataTable dt = new DataTable();

            SqlCommand query = new SqlCommand(procName, sqlConnection);
            query.CommandType = CommandType.StoredProcedure;

            sqlConnection.Open();

            dt.Load(query.ExecuteReader());

            sqlConnection.Close();

            return dt;
        }

        public DataTable GetById(int id, string procName)
        {
            DataTable dt = new DataTable();

            SqlCommand query = new SqlCommand(procName, sqlConnection);
            query.CommandType = CommandType.StoredProcedure;
            query.Parameters.AddWithValue("@Id", id);

            sqlConnection.Open();

            dt.Load(query.ExecuteReader());

            sqlConnection.Close();

            return dt;
        }
        //public DataTable FlightTicketSearch(int flightClassId, DateTime flightDate, DateTime landingDate , string cityOrigin, string cityDestination, string procName)
        //{

        //}

        public DataTable GetFlightTicketSearchResult(int flightClassId, DateTime flightDate, /*DateTime landingDate,*/ int citytOriginId, int cityDestinationId, string procName)
        {
            DataTable dt = new DataTable();

            SqlCommand query = new SqlCommand(procName, sqlConnection);
            query.CommandType = CommandType.StoredProcedure;

            query.Parameters.AddWithValue("@FlightClassId", flightClassId);
            query.Parameters.AddWithValue("@FlightDate",flightDate);
            //query.Parameters.AddWithValue("@LandingDate", landingDate.ToString("yyyy-MM-dd"));
            //query.Parameters.AddWithValue("@NameCityOrigin", cityOrigin);
            //query.Parameters.AddWithValue("@NameCityDestination", cityDestination);
            query.Parameters.AddWithValue("@CitytOriginId", citytOriginId);
            query.Parameters.AddWithValue("@CityDestinationId", cityDestinationId);

            sqlConnection.Open();

            dt.Load(query.ExecuteReader());

            sqlConnection.Close();

            return dt;
        }

        public DataTable GetUserSearch(int cityOriginId, int cityDestinationId, int flightClassId, string procName)
        {
            DataTable dt = new DataTable();

            SqlCommand query = new SqlCommand(procName, sqlConnection);
            query.CommandType = CommandType.StoredProcedure;

            query.Parameters.AddWithValue("@CityOriginId", cityOriginId);
            query.Parameters.AddWithValue("@CityDestinationId", cityDestinationId);
            query.Parameters.AddWithValue("@FlightClassId", flightClassId);

            sqlConnection.Open();

            dt.Load(query.ExecuteReader());

            sqlConnection.Close();

            return dt;
        }
    }
}
