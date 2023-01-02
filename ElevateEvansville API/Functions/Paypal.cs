using ElevateEvansville_API.Models;
using PayPal.PayPalAPIInterfaceService;
using PayPal.PayPalAPIInterfaceService.Model;

namespace ElevateEvansville_API.Functions
{
    public class Paypal
    {

        public static string APIUserName = "";
        public static string APIPassword = "";
        public static string APISignature = "";

        public static class Configuration
        {
            // Creates a configuration map containing credentials and other required configuration parameters
            public static Dictionary<string, string> GetAcctAndConfig()
            {
                Dictionary<string, string> configMap = new Dictionary<string, string>();

                configMap = GetConfig();

                // Signature Credential

                configMap.Add("account1.apiUsername", APIUserName);
                configMap.Add("account1.apiPassword", APIPassword);
                configMap.Add("account1.apiSignature", APISignature);

                return configMap;
            }

            // Creates a configuration map containing mode and other required configuration parameters
            public static Dictionary<string, string> GetConfig()
            {
                Dictionary<string, string> configMap = new Dictionary<string, string>();

                // Endpoints are varied depending on whether sandbox OR live is chosen for mode
                configMap.Add("mode", "live");

                // These values are defaulted in SDK. If you want to override default values, uncomment it and add your value.
                // configMap.Add("connectionTimeout", "5000");
                // configMap.Add("requestRetries", "2");

                return configMap;
            }
        }


        public static string GetBalance()
        {
            // Create request object
            GetBalanceRequestType request = new GetBalanceRequestType();
            // (Optional) Indicates whether to return all currencies. It is one of the following values:
            // * 0 – Return only the balance for the primary currency holding.
            // * 1 – Return the balance for each currency holding.
            // Note: This field is available since version 51. Prior versions return only the balance for the primary currency holding.
            request.ReturnAllCurrencies = "1";

            // Invoke the API
            GetBalanceReq wrapper = new GetBalanceReq();
            wrapper.GetBalanceRequest = request;

            // Configuration map containing signature credentials and other required configuration.
            // For a full list of configuration parameters refer in wiki page 
            // [https://github.com/paypal/sdk-core-dotnet/wiki/SDK-Configuration-Parameters]
            Dictionary<string, string> configurationMap = Configuration.GetAcctAndConfig();

            // Create the PayPalAPIInterfaceServiceService service object to make the API call
            PayPalAPIInterfaceServiceService service = new PayPalAPIInterfaceServiceService(configurationMap);

            // # API call 
            // Invoke the GetBalance method in service wrapper object  
            GetBalanceResponseType getBalanceResponse = service.GetBalance(wrapper);


            return getBalanceResponse.Balance.value.ToString();
        }


        public static List<Transactions> GetTransactions(DateTime QueryStartDate, PaymentTransactionClassCodeType PaymentType)
        {
            TransactionSearchRequestType request = new TransactionSearchRequestType();
           
            request.StartDate = QueryStartDate.AddDays(-1).ToString("yyyy-MM-ddTHH:mm:ss");
            request.EndDate = DateTime.Now.AddDays(1).ToString("yyyy-MM-ddTHH:mm:ss");

            request.TransactionClass = PaymentType;

            // Invoke the API
            TransactionSearchReq wrapper = new TransactionSearchReq();
            wrapper.TransactionSearchRequest = request;

            // Configuration map containing signature credentials and other required configuration.
            // For a full list of configuration parameters refer in wiki page 
            // [https://github.com/paypal/sdk-core-dotnet/wiki/SDK-Configuration-Parameters]
            Dictionary<string, string> configurationMap = Configuration.GetAcctAndConfig();

            // Create the PayPalAPIInterfaceServiceService service object to make the API call
            PayPalAPIInterfaceServiceService service = new PayPalAPIInterfaceServiceService(configurationMap);

            // # API call 
            // Invoke the TransactionSearch method in service wrapper object  
            TransactionSearchResponseType transactionDetails = service.TransactionSearch(wrapper);

            List<PaymentTransactionSearchResultType> PaypalTransactions = transactionDetails.PaymentTransactions;

            GetTransactionDetailsRequestType TransactionDetailRequest = new GetTransactionDetailsRequestType();
            GetTransactionDetailsReq TransactionDetailWrapper = new GetTransactionDetailsReq();


            List<Transactions> TransactionList = new List<Transactions>();
            foreach (PaymentTransactionSearchResultType result in PaypalTransactions)
            {
                TransactionDetailRequest.TransactionID = result.TransactionID;
                TransactionDetailWrapper.GetTransactionDetailsRequest = TransactionDetailRequest;

                GetTransactionDetailsResponseType TransactionIDDetails = service.GetTransactionDetails(TransactionDetailWrapper);

                var InfoType = TransactionIDDetails.PaymentTransactionDetails.PaymentItemInfo;

                var softDescriptor = TransactionIDDetails.PaymentTransactionDetails.PaymentItemInfo.PaymentItem;
                string Name = "";
                try { Name = softDescriptor[0].Name; } catch { Name = ""; }

                BasicAmountType feeAmount = result.FeeAmount;
                BasicAmountType netAmount = result.NetAmount;
                BasicAmountType grossAmount = result.GrossAmount;


                DateTime? TransactionTime = null;
                if (result.Timestamp != null)
                {
                    TransactionTime = Convert.ToDateTime(result.Timestamp);
                }

                TransactionList.Add(new Transactions
                {
                    PaypalTransactionID = result.TransactionID,
                    Class = PaymentType.ToString(),
                    Status = result.Status,
                    Type = result.Type,
                    Name = Name,
                    Memo = InfoType.Memo,
                    Payer = result.Payer,
                    PayerDisplayName = result.PayerDisplayName,
                    FeeAmount = feeAmount.value,
                    NetAmount = netAmount.value,
                    GrossAmount = grossAmount.value,
                    Timestamp = TransactionTime,
                });
            }

            return TransactionList;
        }








        public static string GetInformation()
        {
            // Create request object
            // GetPalDetails does not require you to pass any data other than your credentials
            GetPalDetailsRequestType request = new GetPalDetailsRequestType();

            // Invoke the API
            GetPalDetailsReq wrapper = new GetPalDetailsReq();
            wrapper.GetPalDetailsRequest = request;

            // Configuration map containing signature credentials and other required configuration.
            // For a full list of configuration parameters refer in wiki page 
            // [https://github.com/paypal/sdk-core-dotnet/wiki/SDK-Configuration-Parameters]
            Dictionary<string, string> configurationMap = Configuration.GetAcctAndConfig();

            // Create the PayPalAPIInterfaceServiceService service object to make the API call
            PayPalAPIInterfaceServiceService service = new PayPalAPIInterfaceServiceService(configurationMap);

            // # API call 
            // Invoke the GetPalDetails method in service wrapper object 
            GetPalDetailsResponseType palDetails = service.GetPalDetails(wrapper);

            return palDetails.Ack.ToString();
        }


    }
}
