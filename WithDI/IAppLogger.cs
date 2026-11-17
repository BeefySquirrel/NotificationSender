using System;

namespace NotificationSender.WithDI;

public interface IAppLogger {
        void Log(string message);
    }