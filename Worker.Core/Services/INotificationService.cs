using System;
namespace Worker.Core.Services
{
  public interface INotificationService
  {
    public int SendPushOverAPI(NotificationRequest request);
  }
}

