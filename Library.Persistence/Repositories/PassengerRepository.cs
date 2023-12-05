using Library.Model.Models;
using Library.Persistence.ConnectionStrings;
using Library.Persistence.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Library.Persistence.Repositories
{
    public class PassengerRepository 
    {
        private readonly SqlConnection sqlConnection;
        public PassengerRepository()
        {
            sqlConnection = new SqlConnection(ConnectionString.LibararyConnectionString);
        }

        //public int Add(Passenger passenger)
        //{
        //    var sqlCommand = new SqlCommand("Usp_Book_Add", sqlConnection);
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlCommand.Parameters.AddWithValue("@Name", book.Name);
        //    sqlCommand.Parameters.AddWithValue("@Publisher", book.Publisher);
        //    sqlCommand.Parameters.AddWithValue("@PageCount", book.PageCount);

        //    sqlConnection.Open();

        //    int result = sqlCommand.ExecuteNonQuery();

        //    sqlConnection.Close();

        //    return result;
        //}

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Passenger> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Passenger passenger)
        {
            throw new NotImplementedException();
        }
    }
}
