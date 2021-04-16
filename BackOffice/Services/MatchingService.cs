using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BackOffice.Dtos;
using BackOffice.Helper;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
namespace BackOffice.Services
{

    public class MatchingService : IMatchingService
    {

        private string EndpointUrl => "/api/v1.0/matching";
        private readonly HttpClient _client;

        public MatchingService(HttpClient client)
        {
            this._client = client;
        }
        public async Task<IEnumerable<MatchingTransactionDto>> GetTransactions(MatchingTransactionSearchCriteriaDto criteria)
        {
            try
            {
                
                return await _client.GetFromJsonAsync<IEnumerable<MatchingTransactionDto>>(EndpointUrl);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                throw;
            }

        }
    }
}
