using Library.Model.Models;
using System.Collections.Generic;

namespace Library.Persistence.IRepositories
{
    public interface IPassengerRepository
    {
        int Add(Passenger passenger);
        void Update(int id, Passenger passenger);
        void Delete(int id);
        List<Passenger> Get();
    }
}
