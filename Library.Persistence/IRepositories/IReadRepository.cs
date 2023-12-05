using System;
using System.Data;

namespace Library.Persistence.IRepositories
{
    public interface IReadRepository
    {
        DataTable Get(string procName);
        DataTable GetById(int id, string procName);
        DataTable GetFlightTicketSearchResult(int flightClassId, DateTime flightDate/*, DateTime landingDate*/, int citytOriginId, int cityDestinationId/*, string cityOrigin, string cityDestination*/, string procName);
        DataTable GetUserSearch(int cityOriginId, int cityDestinationId, int flightClassId, string procName);
    }
}
