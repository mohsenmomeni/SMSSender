using SMS.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace SMS.ProvideSMSFeatures
{

    public class BulkMessage
    {
        public string Title { get; private set; }
        public List<string> ValidReceivers { get; private set; }
        public string Message { get; private set; }

        public List<string> InvalidReceivers { get; private set; }
        
        public BulkMessage(string title, List<string> recievers, string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new MessageIsEmptyException();
            if (string.IsNullOrWhiteSpace(title))
                throw new MessageIsEmptyException();
            SeparateValidAndInvalidRecievers(recievers);
            Title = title;
            Message = message;           
        }

        private void SeparateValidAndInvalidRecievers(List<string> recievers)
        {
            ValidReceivers = new List<string>();
            InvalidReceivers = new List<string>();            
            foreach (var item in recievers)
            {
                ValidateReceiver(item);
            }
        }

        private void ValidateReceiver(string item)
        {
            try
            {
                ValidReceivers.Add((new IranMobilePhone()).RefineNumber(item));
            }
            catch (System.Exception ex)
            {
                InvalidReceivers.Add(ex.Message);
            }
        }
    }
}
