﻿namespace Inveon.MessageBus
{
    public interface IMessageBus
    {
        Task PublishMessage(BaseMessage message, string topicName);
    }
}