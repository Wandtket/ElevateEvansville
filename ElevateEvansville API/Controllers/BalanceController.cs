using AutoMapper;
using ElevateEvansville_API.Repositories;
using ElevateEvansville_API.Results;
using ElevateEvansvilleUI.DTOs;
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
        [Route("/Current")]
        [ProducesResponseType(typeof(EnvelopedResult<IEnumerable<BalanceDTO>>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCurrent()
        {
            var Templates = await BalanceRepository.ListAsync();
            List<BalanceDTO> dtos = mapper.Map<List<BalanceDTO>>(Templates);

            return new EnvelopedResult<IEnumerable<BalanceDTO>>(dtos);
        }

    }
}
