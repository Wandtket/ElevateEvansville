using AutoMapper;
using ElevateEvansville_API.Functions;
using ElevateEvansville_API.Repositories;
using ElevateEvansville_API.Results;
using ElevateEvansvilleUI.API.DTOs;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        [Route("/Accounts/New")]
        [ProducesResponseType(typeof(EnvelopedResult<BalanceDTO>), StatusCodes.Status200OK)]
        public async Task<BalanceDTO> GetCurrent()
        {
            //DateTime CurrentDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time"));

            BalanceDTO dto = new BalanceDTO();
            dto.BalanceID = 0;
            dto.Balance = Paypal.GetBalance();

            return dto;
        }



    }
}
