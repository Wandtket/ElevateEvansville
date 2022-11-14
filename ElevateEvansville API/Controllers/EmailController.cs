using AutoMapper;
using ElevateEvansville_API.Configurations;
using ElevateEvansville_API.Functions;
using ElevateEvansville_API.Repositories;
using ElevateEvansville_API.Results;
using ElevateEvansville_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace ElevateEvansville_API.Controllers
{


    [Route("/balance/")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly ILogger<EmailController> logger;

        private IEmailConfiguration EmailConfiguration;
        private IEmailService EmailService;

        private IMapper mapper;


        public EmailController(ILogger<EmailController> _logger, IMapper _mapper, IEmailConfiguration _EmailConfiguration, IEmailService _EmailService)
        {
            logger = _logger;
            mapper = _mapper;
            EmailConfiguration = _EmailConfiguration;
            EmailService = _EmailService;
        }


        [HttpGet]
        [Route("/Send")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public async Task StoreTransactions()
        {
            EmailMessage message = new EmailMessage();
            List<EmailAddress> ToAddresses = new List<EmailAddress>();
            List<EmailAddress> FromAddresses = new List<EmailAddress>();


            EmailAddress ToAddress = new EmailAddress();
            ToAddress.Name = "Tyler Wandtke";
            ToAddress.Address = "wandtket@gmail.com";

            EmailAddress FromAddress = new EmailAddress();
            FromAddress.Name = "Tyler Wandtke";
            FromAddress.Address = "PayPal@ElevateEvansville.com";

            ToAddresses.Add(ToAddress);
            FromAddresses.Add(FromAddress);

            message.FromAddresses = FromAddresses;
            message.ToAddresses = ToAddresses;
            message.Subject = "Test!";
            message.Content = "Another!";

            EmailService.Send(message);

            //Balances balance = new Balances();
            //balance.TotalBalance = "Test!";
            //balance.Created = DateTime.Now;

            //await BalanceRepository.AddAsync(balance);
        }


    }
}
