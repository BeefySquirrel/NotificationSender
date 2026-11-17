using System;

namespace NotificationSender.WithDI;

public class SMSSender:IMessageSender
{
public void Send(string to, string message)
    {
        Console.WriteLine($"SMS to {to} text: {message}");
    }
}
