using AutoMapper;
using ElevateEvansville_API.Functions;
using ElevateEvansville_API.Repositories;
using ElevateEvansville_API.Results;
using ElevateEvansvilleUI.API.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ElevateEvansville_API.Controllers
{

    [Route("/balance/")]
    [ApiController]
    public class BalanceController : ControllerBase
    {
        private readonly ILogger<BalanceController> logger;
        private IBalanceRepository BalanceRepository;
        private IMapper mapper;


        public BalanceController(ILogger<BalanceController> _logger, IMapper _mapper, IBalanceRepository _BalanceRepository)
        {
            logger = _logger;
            mapper = _mapper;
            BalanceRepository = _BalanceRepository;
        }

        [HttpGet]
        [Route("/Total")]
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
