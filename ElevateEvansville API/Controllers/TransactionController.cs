using AutoMapper;
using ElevateEvansville_API.Functions;
using ElevateEvansville_API.Models;
using ElevateEvansville_API.Repositories;
using ElevateEvansville_API.Results;
using ElevateEvansvilleUI.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using System.Transactions;
using PayPal.PayPalAPIInterfaceService.Model;


namespace ElevateEvansville_API.Controllers
{
    [Route("/transaction/")]
    [ApiController]
    public class TransactionController : ControllerBase
    {

        private readonly ILogger<TransactionController> logger;

        private ITransactionRepository TransactionRepository;
        private IMapper mapper;


        public TransactionController(ILogger<TransactionController> _logger, IMapper _mapper, ITransactionRepository _TransactionRepositoryRepository)
        {
            logger = _logger;
            mapper = _mapper;
            TransactionRepository = _TransactionRepositoryRepository;
        }


        /// <summary>
        /// This pulls transactions from Paypal and stores them in cache on the SQL Database to speed up load times for users.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/Transactions/Pull")]
        [ProducesResponseType(typeof(EnvelopedResult<IEnumerable<TransactionsDTO>>), StatusCodes.Status200OK)]
        public async Task PullTransactions()
        {
            DateTime QueryStartDate = await TransactionRepository.GetQueryStartDate();


            //Received Payments
            List<Transactions> ReceivedTransactions = 
                Paypal.GetTransactions(QueryStartDate, PaymentTransactionClassCodeType.RECEIVED);

            foreach (Transactions transaction in ReceivedTransactions)
            {
                bool isDuplicate = await TransactionRepository.IsTransactionDuplicate(transaction.PaypalTransactionID);
                if (isDuplicate == false) { await TransactionRepository.AddItem(transaction); }
            }

            //Sent Payments
            List<Transactions> SentTransactions =
                Paypal.GetTransactions(QueryStartDate, PaymentTransactionClassCodeType.SENT);

            foreach (Transactions transaction in SentTransactions)
            {
                bool isDuplicate = await TransactionRepository.IsTransactionDuplicate(transaction.PaypalTransactionID);
                if (isDuplicate == false) { await TransactionRepository.AddItem(transaction); }
            }

            //Funds Withdrawn
            List<Transactions> FundsWithDrawnTransactions =
                Paypal.GetTransactions(QueryStartDate, PaymentTransactionClassCodeType.FUNDSWITHDRAWN);

            foreach (Transactions transaction in FundsWithDrawnTransactions)
            {
                bool isDuplicate = await TransactionRepository.IsTransactionDuplicate(transaction.PaypalTransactionID);
                if (isDuplicate == false) { await TransactionRepository.AddItem(transaction); }
            }

            //Funds Added
            List<Transactions> FundsAddedTransactions =
                Paypal.GetTransactions(QueryStartDate, PaymentTransactionClassCodeType.FUNDSADDED);

            foreach (Transactions transaction in FundsAddedTransactions)
            {
                bool isDuplicate = await TransactionRepository.IsTransactionDuplicate(transaction.PaypalTransactionID);
                if (isDuplicate == false) { await TransactionRepository.AddItem(transaction); }
            }

            //Refunds
            List<Transactions> RefundTransactions =
               Paypal.GetTransactions(QueryStartDate, PaymentTransactionClassCodeType.REFUND);

            foreach (Transactions transaction in RefundTransactions)
            {
                bool isDuplicate = await TransactionRepository.IsTransactionDuplicate(transaction.PaypalTransactionID);
                if (isDuplicate == false) { await TransactionRepository.AddItem(transaction); }
            }

            //Balance Transfers
            List<Transactions> BalanceTransferTransactions =
               Paypal.GetTransactions(QueryStartDate, PaymentTransactionClassCodeType.BALANCETRANSFER);

            foreach (Transactions transaction in BalanceTransferTransactions)
            {
                bool isDuplicate = await TransactionRepository.IsTransactionDuplicate(transaction.PaypalTransactionID);
                if (isDuplicate == false) { await TransactionRepository.AddItem(transaction); }
            }

            //Balance Affecting
            List<Transactions> BalanceAffectingTransactions =
               Paypal.GetTransactions(QueryStartDate, PaymentTransactionClassCodeType.BALANCEAFFECTING);

            foreach (Transactions transaction in BalanceAffectingTransactions)
            {
                bool isDuplicate = await TransactionRepository.IsTransactionDuplicate(transaction.PaypalTransactionID);
                if (isDuplicate == false) { await TransactionRepository.AddItem(transaction); }
            }

            //Mass Pays
            List<Transactions> MassPayTransactions =
               Paypal.GetTransactions(QueryStartDate, PaymentTransactionClassCodeType.MASSPAY);

            foreach (Transactions transaction in MassPayTransactions)
            {
                bool isDuplicate = await TransactionRepository.IsTransactionDuplicate(transaction.PaypalTransactionID);
                if (isDuplicate == false) { await TransactionRepository.AddItem(transaction); }
            }


            //Reversals
            List<Transactions> ReversalTransactions =
               Paypal.GetTransactions(QueryStartDate, PaymentTransactionClassCodeType.REVERSAL);

            foreach (Transactions transaction in ReversalTransactions)
            {
                bool isDuplicate = await TransactionRepository.IsTransactionDuplicate(transaction.PaypalTransactionID);
                if (isDuplicate == false) { await TransactionRepository.AddItem(transaction); }
            }

            //Money Requests
            List<Transactions> RequestsTransactions =
               Paypal.GetTransactions(QueryStartDate, PaymentTransactionClassCodeType.MONEYREQUEST);

            foreach (Transactions transaction in RequestsTransactions)
            {
                bool isDuplicate = await TransactionRepository.IsTransactionDuplicate(transaction.PaypalTransactionID);
                if (isDuplicate == false) { await TransactionRepository.AddItem(transaction); }
            }
        }



        /// <summary>
        /// This pulls the transactions stored in the SQL Database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/Transactions/Get")]
        [ProducesResponseType(typeof(EnvelopedResult<IEnumerable<TransactionsDTO>>), StatusCodes.Status200OK)]
        public async Task<TransactionListDTO> GetTransactions()
        {
            var Transactions = await TransactionRepository.ListAsync();
            List<TransactionsDTO> dtos = mapper.Map<List<TransactionsDTO>>(Transactions);

            TransactionListDTO List = new TransactionListDTO();
            List.Transactions = dtos.OrderByDescending(x => x.Timestamp);

            return List;
        }








    }
}
