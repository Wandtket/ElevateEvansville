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
        public async Task<string> Request(SignaturesDTO requestDto)
        {
            try
            {
                var Existing = await SignaturesRepository.GetByEmail(requestDto.Email);
                if (Existing == null)
                {
                    Signatures signature = mapper.Map<Signatures>(requestDto);
                    await SignaturesRepository.AddAsync(signature);
                    await SignaturesRepository.SaveChangesAsync();

                    return "Success";
                }
                else
                {
                    Existing.LastName = requestDto.LastName;
                    Existing.FirstName = requestDto.FirstName;
                    Existing.Address = requestDto.Address;
                    Existing.Zip = requestDto.Zip;
                    Existing.Notes = requestDto.Notes;
                    Existing.Phone = requestDto.Phone;
                    Existing.MaskRequested = requestDto.MaskRequested;
                    Existing.Anytime = requestDto.Anytime;
                    Existing.PreferredTimeStart = requestDto.PreferredTimeStart;
                    Existing.PreferredTimeEnd = requestDto.PreferredTimeEnd;
                    Existing.PrefersMonday = requestDto.PrefersMonday;
                    Existing.PrefersTuesday = requestDto.PrefersTuesday;
                    Existing.PrefersWednesday = requestDto.PrefersWednesday;
                    Existing.PrefersThursday = requestDto.PrefersThursday;
                    Existing.PrefersFriday = requestDto.PrefersFriday;
                    Existing.PrefersSaturday = requestDto.PrefersSaturday;
                    Existing.PrefersSunday = requestDto.PrefersSunday;

                    await SignaturesRepository.UpdateAsync(Existing);
                    await SignaturesRepository.SaveChangesAsync();

                    return "Updated";
                }
            }
            catch (Exception ex) 
            {
                return ex.Message;
            }
        }

        [HttpDelete]
        [Route("/Signatures/Delete/{Email}")]
        public async Task<string> Delete([FromRoute]string Email)
        {
            try
            {
                var Sig = await SignaturesRepository.GetByEmail(Email);
                
                if (Sig != null)
                {
                    await SignaturesRepository.DeleteAsync(Sig);
                    return "Request Removed";
                }
                else { return "No request could be found."; }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }



    }
}
