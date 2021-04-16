using System.Collections.Generic;
using System.Threading.Tasks;
using BackOffice.Dtos;

namespace BackOffice.Services
{
    public interface IMatchingService
    {
        Task<IEnumerable<MatchingTransactionDto>> GetTransactions(MatchingTransactionSearchCriteriaDto criteria);
    }
}
