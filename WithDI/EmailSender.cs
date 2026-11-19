using System;

namespace NotificationSender.WithDI;

public class EmailSender:IMessageSender
{
    public Guid Id { get; } = Guid.NewGuid();  // уникальная метка экземпляра
public void Send(string to, string message)
    {
        Console.WriteLine($"кому: {to} E-mail: {message}");
    }
}
