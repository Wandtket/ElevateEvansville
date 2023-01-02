using ElevateEvansvilleUI.API.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ApiClient.Shared.WebServices;

namespace ElevateEvansvilleUI.API.Services
{
    public class SignatureService : WebApiBase
    {
        public async Task<string> SubmitRequest(SignaturesDTO request)
        {
            var result = await this.PostAsync(
                $"https://elevateevansvilleapi.azure-api.net/Signatures/Request", 
                JsonSerializer.Serialize(request));

            return result;
        }

    }
}
