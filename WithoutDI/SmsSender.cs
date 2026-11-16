using System;

namespace NotificationSender.WithoutDI;

public class SmsSender
{
public void send(string to, string message)
    {
        Console.WriteLine($"SMS to {to} text: {message}");
    }
}
