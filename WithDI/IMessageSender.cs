using System;

namespace NotificationSender.WithDI;

public interface IMessageSender {
        void Send(string to, string message);
    }
