using System;
using Moq;
using Shouldly;
using Worker.Core.Services;
using Xunit;

namespace Worker.Core
{
  public class NotificationProcessorTest
  {
    private NotificationRequest _request;
    private Mock<INotificationService> _serviceMock;
    private NotificationProcessor _processor;

    public NotificationProcessorTest()
    {
      //Arrange
      _request = new NotificationRequest
      {
        Date = new DateTime(2022, 11, 12),
        Application = "Dashboard",
        Message = "Buy toothpaste"
      };

      _serviceMock = new Mock<INotificationService>();
      _serviceMock.Setup(p => p.SendPushOverAPI(_request)).Returns(1);
      _processor = new NotificationProcessor(_serviceMock.Object);
    }

    [Fact]
    public void Should_Send_Push_Notifcation()
    {

      //Act
      var result = _processor.SendNotification(_request);

      //Assert
      result.ShouldBeTrue();
    }
  }
}

