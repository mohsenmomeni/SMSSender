using SMSSend;
using System;
using System.ServiceModel;
using System.Threading.Tasks;

namespace SMS
{
    public class AtiehSMSProvider : ISMSProvider
    {
        public ISMSConfiguration Config { get; private set; }
        private JaxRpcMessagingServiceClient serviceClient;

        public AtiehSMSProvider(ISMSConfiguration config)
        {
            Config = config;
            serviceClient = new JaxRpcMessagingServiceClient();
            serviceClient.Endpoint.Address =
                new EndpointAddress(
                        string.Format("http://{0}/services/MessagingService?wsdl", Config.Address));
        }

        public Result SendSimple(SimpleMessage simpleMessage)
        {
            var destNumbers = GetDestNumbers(simpleMessage.PhoneNumber);
            var result = serviceClient.sendAsync(
                            Config.Username,
                            Config.Password,
                            Config.SourceNo,
                            destNumbers,
                            null,
                            null,
                            GetClientIDs(),
                            (short)AtiehMessageType.Plaintext,
                            (short)AtiehEncodingType.UniCode,
                            true,
                            DateTime.Now,
                            simpleMessage.Message
                            );
            return HandleResult(destNumbers[0], result);
        }

        public string Inbox()
        {
            var x = serviceClient.receiveAsync(Config.Username, Config.Password, Config.SourceNo, 0, 700);
            var result = x.Result.messages;
            return null;
        }
        
        private Result HandleResult(string number, Task<sendResponse> result)
        {
            if (result == null)
                throw new ResultIsNullException();
            if (result.Result == null 
                || result.Result.sendReturn == null 
                || result.Result.sendReturn.id == null
                || result.Result.sendReturn.id.Length <= 0)
            {
                throw new ResultIsNullException();
            }
            return new
                Result(GetResultStatus(result.Result.sendReturn.status));
        }

        private ResultStatus GetResultStatus(short status)
        {
            return status == 0 ? ResultStatus.Successful : ResultStatus.Unsuccessful;
        }

        private string[] GetDestNumbers(string phoneNumber)
        {
            string[] destNumbers = new string[1];
            destNumbers[0] = (new IranMobilePhone()).RefineNumberAndAddCountryCode(phoneNumber);
            return destNumbers;
        }

        private string[] GetClientIDs()
        {
            var clientId = Guid.NewGuid().GetHashCode().ToString().Replace("-", "");
            var clients = new string[1];
            clients[0] = clientId;
            return clients;
        }
    }
}
