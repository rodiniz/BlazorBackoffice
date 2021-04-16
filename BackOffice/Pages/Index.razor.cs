using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackOffice.Dtos;
using BackOffice.Helper;
using BackOffice.Services;
using BackOffice.State;
using Microsoft.AspNetCore.Components;

namespace BackOffice.Pages
{
    public partial class Index
    {

        [Inject] private  IMatchingService MatchingService { get; set; }

        private IEnumerable<MatchingTransactionDto> Transactions { get; set; }

        private void SearchTransactions(MatchingTransactionSearchCriteriaDto criteria)
        {
            var filteredTransactions = FakeState.Transactions;
            if (!string.IsNullOrEmpty(criteria.OrderId))
            {
                filteredTransactions = filteredTransactions.Where(c =>
                    !string.IsNullOrEmpty(c.OrderId) && c.OrderId.Contains(criteria.OrderId));
            }
            if (criteria.ValidityStartDate.HasValue)
            {
                filteredTransactions =
                    filteredTransactions.Where(c => c.ValueDate.Parse() >= criteria.ValidityStartDate.Value);
            }
            if (criteria.ValidityEndDate.HasValue)
            {
                filteredTransactions =
                    filteredTransactions.Where(c => c.ValueDate.Parse() <= criteria.ValidityEndDate.Value);
            }
            if (criteria.ReceptionDate.HasValue)
            {
                filteredTransactions =
                    filteredTransactions.Where(c => c.FileReceptionDate.Parse() <= criteria.ReceptionDate.Value);
            }
            if (!string.IsNullOrEmpty(criteria.OperationStatus))
            {
                filteredTransactions =
                    filteredTransactions.Where(c => c.OperationStatus== criteria.OperationStatus);
            }
            Transactions = filteredTransactions;
        }
        protected override async Task OnInitializedAsync()
        {
            FakeState.Transactions = await MatchingService.GetTransactions(new MatchingTransactionSearchCriteriaDto());
            Transactions = FakeState.Transactions;
            await base.OnInitializedAsync();
        }
    }
}
