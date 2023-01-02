using AutoMapper;
using ElevateEvansville_API.Functions;
using ElevateEvansville_API.Models;
using ElevateEvansville_API.Repositories;
using ElevateEvansville_API.Results;
using ElevateEvansvilleUI.API.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Security.Permissions;

namespace ElevateEvansville_API.Controllers
{

    [Route("/signatures/")]
    [ApiController]
    public class SignaturesController : ControllerBase
    {
        private readonly ILogger<SignaturesController> logger;
        private ISignaturesRepository SignaturesRepository;
        private IMapper mapper;

        public SignaturesController(ILogger<SignaturesController> _logger, IMapper _mapper, ISignaturesRepository _SignaturesRepository)
        {
            logger = _logger;
            mapper = _mapper;
            SignaturesRepository = _SignaturesRepository;
        }


        [HttpPost]
        [Route("/Signatures/Request")]
        public async Task<string> Request(SignaturesDTO request)
        {
            try
            {
                Signatures signature = mapper.Map<Signatures>(request);
                await SignaturesRepository.AddAsync(signature);
                await SignaturesRepository.SaveChangesAsync();

                return "Success";
            }
            catch (Exception ex) 
            {
                return ex.Message;
            }
        }



    }
}
