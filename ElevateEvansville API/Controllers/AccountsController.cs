using AutoMapper;
using ElevateEvansville_API.Functions;
using ElevateEvansville_API.Models;
using ElevateEvansville_API.Repositories;
using ElevateEvansville_API.Results;
using ElevateEvansvilleUI.API.DTOs;
using ElevateEvansvilleUI.API.Requests;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ElevateEvansville_API.Controllers
{

    [Route("/accounts/")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly ILogger<AccountsController> logger;
        private IAccountsRepository AccountsRepository;
        private IMapper mapper;

        public AccountsController(ILogger<AccountsController> _logger, IMapper _mapper, IAccountsRepository _AccountsRepository)
        {
            logger = _logger;
            mapper = _mapper;
            AccountsRepository = _AccountsRepository;
        }

        [HttpPost]
        [Route("/Accounts/Create")]
        public async Task<string> Create(AccountsDTO dto)
        {
            try
            {
                Accounts account = mapper.Map<Accounts>(dto);

                bool EmailUsed = await AccountsRepository.IsEmailUsed(account.Email);
                if (EmailUsed == true) { return "Email Already Used"; }

                await AccountsRepository.AddAsync(account);
                await AccountsRepository.SaveChangesAsync();

                return "Success";
            }
            catch (Exception ex) { return "Error"; }
        }

        [HttpPost]
        [Route("/Accounts/Validate")]
        public async Task<string> Validate(AccountsDTO dto)
        {
            bool Valid = await AccountsRepository.ValidatePassword(dto.Email, dto.Password);

            if (Valid == true)
            {
                Accounts Account = await AccountsRepository.GetByEmail(dto.Email);
                AccountsDTO ReturnDto = mapper.Map<AccountsDTO>(Account);
                ReturnDto.Password = "";
                ReturnDto.MachineId = "";
                return JsonSerializer.Serialize(ReturnDto);;
            }
            else
            {
                return null;
            }
        }


        [HttpPost]
        [Route("/Accounts/Update")]
        public async Task<string> Update(AccountUpdateRequest request)
        {
            bool Valid = await AccountsRepository.ValidatePassword(request.CurrentEmail, request.CurrentPassword);

            if (Valid == true)
            {
                Accounts Account = await AccountsRepository.GetByEmail(request.CurrentEmail);

                if (request.NewEmail != "") { Account.Email = request.NewEmail; }
                if (request.NewPassword != "") { Account.Password = request.NewPassword; }
                if (request.NewPhone != "") { Account.Phone = request.NewPhone; }

                await AccountsRepository.UpdateAsync(Account);
                await AccountsRepository.SaveChangesAsync();

                AccountsDTO ReturnDto = mapper.Map<AccountsDTO>(Account);
                ReturnDto.Password = "";
                ReturnDto.MachineId = "";
                return JsonSerializer.Serialize(ReturnDto);
            }
            else
            {
                return null;
            }
        }

    }
}
