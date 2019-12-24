using System;

namespace SMS
{
    public class SendSMSEventArgs : EventArgs
    {
        public string PhoneNumber { get; private set; }
        public Result Result { get; private set; }
        public SendSMSEventArgs(string phoneNumber, Result result)
        {
            PhoneNumber = phoneNumber;
            Result = result;
        }
    }
}
