using ElevateEvansvilleUI.API.DTOs;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using ApiClient.Shared.WebServices;

namespace ElevateEvansvilleUI.API.Services
{

    public class PayPalService : WebApiBase
    {

        public async Task<BalanceDTO> GetBalance()
        {
            var result = await this.GetAsync($"https://elevateevansvilleapi.azure-api.net/Total");
            return JsonSerializer.Deserialize<BalanceDTO>(result);
        }

        public async Task<TransactionListDTO> GetTransactions()
        {
            var result = await this.GetAsync(
                $"https://elevateevansvilleapi.azure-api.net/Transactions/Get",
                new Dictionary<string, string> {
                {"accept", "application/json" },
                {"Ocp-Apim-Subscription-Key", "578ae136a0de45f69a372e52014a53b5"}
                });
               
            return JsonSerializer.Deserialize<TransactionListDTO>(result);
            

            //return JsonSerializer.Deserialize<IEnumerable<TransactionsDTO>>(result);

            //return result;
        }       
    }


}
