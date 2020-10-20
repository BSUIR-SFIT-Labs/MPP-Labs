using System;

namespace EmailSenderWebService
{
    public class EmailSender : IEmailSender
    {
        public string GetData(int value)
        {
            return $"You entered: {value}";
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null) throw new ArgumentNullException(nameof(composite));
            if (composite.BoolValue) composite.StringValue += "Suffix";
            return composite;
        }
    }
}