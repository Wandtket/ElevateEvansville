﻿using ApiClient.Shared.WebServices;
using ElevateEvansvilleUI.API.DTOs;
using ElevateEvansvilleUI.API.Requests;
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

        public async Task<AccountsDTO> Validate(AccountsDTO request)
        {
            var result = await this.PostAsync(
                $"https://elevateevansvilleapi.azure-api.net/Accounts/Validate",
                JsonSerializer.Serialize(request));

            return JsonSerializer.Deserialize<AccountsDTO>(result);
        }

        public async Task<AccountsDTO> Update(AccountUpdateRequest request)
        {
            var result = await this.PostAsync(
                $"https://elevateevansvilleapi.azure-api.net/Accounts/Update",
                JsonSerializer.Serialize(request));

            return JsonSerializer.Deserialize<AccountsDTO>(result);
        }
    }
}
