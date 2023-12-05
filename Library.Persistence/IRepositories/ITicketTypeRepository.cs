using System.Data;

namespace Library.Persistence.IRepositories
{
    public interface ITicketTypeRepository
    {
        DataTable Get(string procName);
    }
}
