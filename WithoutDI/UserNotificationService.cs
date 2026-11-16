namespace NotificationSender.WithoutDI;

/// <summary>
/// ЗАДАНИЕ 1.1 — сервис уведомлений БЕЗ DI (жёсткая связанность).
///
/// Что нужно сделать самостоятельно (см. гайд, блок 1.1):
///  1. Создайте в этой папке FileLogger.cs — класс с методом Log(string message),
///     дописывающим строку в файл log.txt (File.AppendAllText).
///  2. Создайте EmailSender.cs — класс с методом Send(string to, string message),
///     который просто выводит "[EMAIL] ..." в консоль.
///  3. В методе Notify ниже создайте оба объекта напрямую через new,
///     отправьте сообщение и запишите действие в лог.
///  4. Проверьте userId на пустоту (ArgumentException).
///  5. Затем смоделируйте требование «нужен SMS вместо email»: SmsSender.cs
///     и замена одной строки здесь. Посчитайте, сколько мест пришлось менять.
/// </summary>
public class UserNotificationService
{
    public void Notify(string userId, string message)
    {
        // TODO: реализовать по заданию 1.1
        throw new NotImplementedException();
    }
}
