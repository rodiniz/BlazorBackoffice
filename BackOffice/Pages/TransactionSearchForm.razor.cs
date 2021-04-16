

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BackOffice.Dtos;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace BackOffice.Pages
{
    public partial class TransactionSearchForm
    {
        [Parameter] public EventCallback<MatchingTransactionSearchCriteriaDto> OnSearchTransactions { get; set; }
        private MatchingTransactionSearchCriteriaDto Model { get; set; }


        public List<CheckBoxFilter> StatusOptions { get; set; }

        public TransactionSearchForm()
        {
            Model = new MatchingTransactionSearchCriteriaDto();
            StatusOptions = new List<CheckBoxFilter>();
            foreach (var opt in Enum.GetValues(typeof(MatchingStatus)))
            {
                var name = Enum.GetName(typeof(MatchingStatus), opt);
                StatusOptions.Add( new CheckBoxFilter(name ?? string.Empty,false));
            }
        }

        private async Task OnValidSubmit(EditContext context)
        {
            await OnSearchTransactions.InvokeAsync(Model);
        }

        private void SelectAllMatchingStatus()
        {
            foreach (var option in StatusOptions)
            {
                option.Checked = true;
            }
        }
    }
}