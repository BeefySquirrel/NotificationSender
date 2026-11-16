using System;

namespace NotificationSender.WithoutDI;

public class EmailSender
{
public void Send(string to, string message)
    {
        Console.WriteLine($"Сообщение: {message} Кому: {to}");
    }
}
