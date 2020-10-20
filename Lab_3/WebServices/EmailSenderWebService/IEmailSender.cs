﻿using System.Runtime.Serialization;
using System.ServiceModel;

namespace EmailSenderWebService
{
    [ServiceContract]
    public interface IEmailSender
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
    }

    [DataContract]
    public class CompositeType
    {
        [DataMember] public bool BoolValue { get; set; } = true;

        [DataMember] public string StringValue { get; set; } = "Hello ";
    }
}