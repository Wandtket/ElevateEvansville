using ApiClient.Shared.WebServices;
using ElevateEvansvilleUI.API.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ElevateEvansvilleUI.API.Services
{

    class AccountService : WebApiBase
    {
        public async Task<string> Create(AccountsDTO request)
        {
            var result = await this.PostAsync(
                $"https://elevateevansvilleapi.azure-api.net/Accounts/Create",
                JsonSerializer.Serialize(request));

            return result;
        }

        public async Task<bool> Validate(AccountsDTO request)
        {
            var result = await this.PostAsync(
                $"https://elevateevansvilleapi.azure-api.net/Accounts/Validate",
                JsonSerializer.Serialize(request));

            return Convert.ToBoolean(result);
        }
    }
}
