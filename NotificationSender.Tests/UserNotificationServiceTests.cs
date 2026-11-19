namespace NotificationSender.Tests;
using Moq;
using NotificationSender.WithDI;

public class UnitTest1
{
    [Fact]
    public void Notify_SendsMessageToGivenUser()
    {
        // Arrange — готовим подделки и сервис
        var senderMock = new Mock<IMessageSender>();
        var loggerMock = new Mock<IAppLogger>();
        var service = new UserNotificationService(senderMock.Object, loggerMock.Object);

        // Act — одно действие
        service.Notify("user-1", "Ваш заказ готов");

        // Assert — проверяем записи вызовов
        senderMock.Verify(
            s => s.Send("user-1", "Ваш заказ готов"),
            Times.Once);   // Send вызван ровно 1 раз, с этими аргументами
        loggerMock.Verify(
            l => l.Log(It.IsAny<string>()),
            Times.Once);   // Log вызван ровно 1 раз, аргумент любой
    }
    
    [Theory]                   // параметризованный тест: один метод, много наборов данных
    [InlineData("")]
    [InlineData(null)]
    [InlineData("   ")]
    public void Notify_InvalidUserId(string? userId)
    {
        var senderMock = new Mock<IMessageSender>();
        var loggerMock = new Mock<IAppLogger>();
        var service = new UserNotificationService(senderMock.Object, loggerMock.Object);
        Assert.Throws<ArgumentException>(() => service.Notify(userId!, "Ваш заказ готов"));
        senderMock.Verify(s => s.Send(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
        loggerMock.Verify(l => l.Log(It.IsAny<string>()), Times.Never);
    }
}
