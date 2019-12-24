using System;
using System.Collections.Generic;

namespace SMS.ProvideSMSFeatures
{
    public class BulkMessageSender
    {
        public event EventHandler<SendSMSEventArgs> OneSendHandled;

        public ISMSProvider Sender { get; private set; }
        public IResultRegistrar ResultRegistrar { get; private set; }

        public BulkMessageSender(
                        IResultRegistrar registrar,
                        ISMSProvider sender)
        {
            ResultRegistrar = registrar;
            Sender = sender;
        }

        public List<Result> Send(BulkMessage bulkMessage)
        {
            List<Result> results = new List<Result>();
            foreach (var item in bulkMessage.ValidReceivers)
            {
                results.Add(
                    SendOneOfList(bulkMessage.Title, bulkMessage.Message, item));
            }
            return results;
        }

        private Result SendOneOfList(string bulkTitle, string message, string phoneNumber)
        {
            Result result = SendWhenItIsntDuplicate(bulkTitle, message, phoneNumber);
            RaiseOneSendHandledEvent(phoneNumber, result);
            return result;
        }

        private Result SendWhenItIsntDuplicate(string bulkTitle, string message, string phoneNumber)
        {
            Result result = null;
            if (ResultRegistrar.IsRegistered(bulkTitle, phoneNumber))
            {
                result = new Result(ResultStatus.IsDuplicate);
            }
            else
            {
                result = Send(bulkTitle, message, phoneNumber);
            }

            return result;
        }

        private void RaiseOneSendHandledEvent(string phoneNumber, Result result)
        {
            if (OneSendHandled != null)
            {
                OneSendHandled.Invoke(this, new SendSMSEventArgs(phoneNumber, result));
            }
        }

        private Result Send(string bulkTitle, string message, string phoneNumber)
        {
            Result result;
            try
            {
                result = Sender.SendSimple(new SimpleMessage(phoneNumber, message));
                ResultRegistrar.RegisterResult(bulkTitle, phoneNumber, result);
            }
            catch (Exception ex)
            {
                result = new Result(ResultStatus.Unsuccessful, ex);
            }

            return result;
        }
    }
}
