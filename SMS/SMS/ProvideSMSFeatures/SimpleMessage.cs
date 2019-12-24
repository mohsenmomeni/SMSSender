using SMS.Exceptions;

namespace SMS
{
    public class SimpleMessage
    {
        public string PhoneNumber { get; private set; }
        public string Message { get; private set; }

        public SimpleMessage(string phoneNumber, string message)
        {
            IranMobilePhone phone = new IranMobilePhone();
            if (!phone.IsValid(phoneNumber))
            {
                throw new PhoneNumberInvalidException(phoneNumber);
            }
            if (string.IsNullOrWhiteSpace(message))
                throw new MessageIsEmptyException();
            PhoneNumber = phoneNumber;
            Message = message;
        }
    }   
}
