using Library.Model.Models;

namespace Library.Persistence.IRepositories
{
    public interface IAirlineRepository : IReadRepository
    {
        int Add(Airline airline);
    }
}
