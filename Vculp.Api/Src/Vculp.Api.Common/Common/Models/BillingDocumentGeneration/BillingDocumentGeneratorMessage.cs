﻿using System;

namespace Vculp.Api.Common.Common.Models.BillingDocumentGeneration
{
    public class BillingDocumentGeneratorMessage
    {
        public BillingDocumentGeneratorMessage(
            string messageType,
            object payload)
        {
            if (string.IsNullOrWhiteSpace(messageType))
            {
                throw new ArgumentException($"{nameof(messageType)} cannot be null, empty or contain only whitespace.", nameof(messageType));
            }

            MessageType = messageType;
            Payload = payload ?? throw new ArgumentNullException(nameof(payload));
        }

        public string MessageType { get; }
        public object Payload { get; }
    }
}
