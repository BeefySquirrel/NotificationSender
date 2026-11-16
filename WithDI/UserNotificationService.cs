namespace NotificationSender.WithDI;

/// <summary>
/// ЗАДАНИЕ 1.2 — тот же сервис, но С внедрением зависимостей.
///
/// Что нужно сделать самостоятельно (см. гайд, блок 1.2):
///  1. Выделите контракты: интерфейсы IMessageSender (Send) и IAppLogger (Log).
///  2. Сервис должен зависеть от интерфейсов, а не от конкретных классов:
///     зависимости приходят через КОНСТРУКТОР и сохраняются в readonly-поля.
///  3. Конкретные реализации (EmailSender/SmsSender, FileLogger)
///     реализуют эти интерфейсы.
///  4. В Program.cs зарегистрируйте зависимости в контейнере
///     Microsoft.Extensions.DependencyInjection (NuGet-пакет) и получите сервис.
///
/// Обратите внимание: контейнер — это лишь способ собрать объект снаружи.
/// new UserNotificationService(sender, logger) в тесте — тоже DI, только ручное.
/// </summary>
public sealed class UserNotificationService
{
    // TODO: поля для зависимостей (интерфейсы, не классы!)

    // TODO: конструктор, принимающий зависимости

    public void Notify(string userId, string message)
    {
        // TODO: реализовать по заданию 1.2
        throw new NotImplementedException();
    }
}
