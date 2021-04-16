using System.Collections.Generic;
using BackOffice.Dtos;

namespace BackOffice.State
{
    public static class FakeState
    {
        public static IEnumerable<MatchingTransactionDto> Transactions { get; set; }
    }
}
