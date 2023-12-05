using System.Data;

namespace Library.Persistence.IRepositories
{
    public interface ICityRepository : IReadRepository
    {
        DataTable Get(string procName);
    }
}
