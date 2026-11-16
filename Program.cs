// NotificationSender — учебный проект по заданиям 1.1 и 1.2 (DI).
//
// Точка входа. Здесь ничего не реализовано намеренно.
//
// Задание 1.1: создайте WithoutDI.UserNotificationService и вызовите
//   service.Notify("user-1", "Ваш заказ готов"); несколько раз.
//
// Задание 1.2: соберите WithDI.UserNotificationService через контейнер
//   Microsoft.Extensions.DependencyInjection и вызовите Notify отсюда.
using NotificationSender.WithoutDI;
 
var service = new UserNotificationService();

service.Notify("user-4", "Ваш первый заказ готов");
service.Notify("user-3", "Документы сброшюрованы бля буду");