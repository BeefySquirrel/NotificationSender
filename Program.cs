// NotificationSender — учебный проект (задания 1.1–1.4).
using NotificationSender.WithDI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddSingleton<IAppLogger, FileLogger>();

// Задание 1.4: канал выбирается из appsettings.json, а не зашит в коде.
// Поменяйте "Channel" в appsettings.json на "Sms" или "Email" — код не трогаем.
var channel = builder.Configuration["Notifications:Channel"];

if (channel == "Sms")
    builder.Services.AddSingleton<IMessageSender, SMSSender>();
else if (channel == "Email")
    builder.Services.AddSingleton<IMessageSender, EmailSender>();
else
    throw new InvalidOperationException($"Unknown channel: {channel}");

builder.Services.AddSingleton<UserNotificationService>();

using var host = builder.Build();
var service = host.Services.GetRequiredService<UserNotificationService>();
service.Notify("user-1", "Ваш заказ готов");
service.Notify("user-4", "Ваш четенький заказ готов");

/* Эксперимент с временем жизни (задание 1.2) — оставлен для истории.
   Для него регистрацию выше надо заменить на AddScoped<IMessageSender, EmailSender>().
using var scope1 = host.Services.CreateScope();
var a = (EmailSender)scope1.ServiceProvider.GetRequiredService<IMessageSender>();
var b = (EmailSender)scope1.ServiceProvider.GetRequiredService<IMessageSender>(); // тот же Id, что у a

using var scope2 = host.Services.CreateScope();
var c = (EmailSender)scope2.ServiceProvider.GetRequiredService<IMessageSender>(); // другой Id
Console.WriteLine(a.Id);
Console.WriteLine(b.Id);
Console.WriteLine(c.Id);
*/
