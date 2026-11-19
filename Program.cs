// NotificationSender — учебный проект по заданиям 1.1 и 1.2 (DI).
//
// Точка входа. Здесь ничего не реализовано намеренно.
//
// Задание 1.1: создайте WithoutDI.UserNotificationService и вызовите
//   service.Notify("user-1", "Ваш заказ готов"); несколько раз.
//
// Задание 1.2: соберите WithDI.UserNotificationService через контейнер
//   Microsoft.Extensions.DependencyInjection и вызовите Notify отсюда.
using NotificationSender.WithDI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
 
var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddSingleton<IAppLogger, FileLogger>();
builder.Services.AddScoped<IMessageSender, EmailSender>();
builder.Services.AddSingleton<UserNotificationService>();
 
using var host = builder.Build();
/*var service = host.Services.GetRequiredService<UserNotificationService>();
service.Notify("user-1", "Ваш заказ готов");
service.Notify("user-4", "Ваш четенький заказ готов");
service.Notify("user-3", "Документы сброшюрованы бля буду");*/
/*var a = (EmailSender)host.Services.GetRequiredService<IMessageSender>();
var b = (EmailSender)host.Services.GetRequiredService<IMessageSender>();*/
using var scope1 = host.Services.CreateScope();
var a = (EmailSender)scope1.ServiceProvider.GetRequiredService<IMessageSender>();
var b = (EmailSender)scope1.ServiceProvider.GetRequiredService<IMessageSender>(); // тот же Id, что у a

using var scope2 = host.Services.CreateScope();
var c = (EmailSender)scope2.ServiceProvider.GetRequiredService<IMessageSender>(); // другой Id
Console.WriteLine(a.Id);
Console.WriteLine(b.Id);
Console.WriteLine(c.Id);

