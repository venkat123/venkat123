﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;

namespace IServiceOriented.ServiceBus.Delivery.Formatters
{
    internal class RawMessageMessageDeliveryConverter : MessageContractMessageDeliveryConverter
    {
        public RawMessageMessageDeliveryConverter(Type contractType)
            : base(contractType)
        {

        }

        public RawMessageMessageDeliveryConverter(ContractDescription contract) : base(contract)
        {
        }

        protected override object GetMessageObject(System.ServiceModel.Channels.Message message)
        {
            return message;
        }

        protected override System.ServiceModel.Channels.Message ToMessageCore(MessageDelivery delivery)
        {
            Message message = (Message)delivery.Message;
            MessageBuffer buffer = message.CreateBufferedCopy(int.MaxValue);
            return buffer.CreateMessage();         
        }
    }
}
