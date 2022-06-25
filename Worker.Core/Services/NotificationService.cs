using System;
using PushoverClient;
using Worker.Core.Services;

namespace Worker.Core
{
  public class NotificationService : INotificationService
  {
    public int SendPushOverAPI(NotificationRequest request)
    {
      Pushover pclient = new Pushover(Environment.GetEnvironmentVariable("PUSHOVER__APP__KEY"));

      PushResponse response = pclient.Push(
          request.Application,
          request.Message,
          Environment.GetEnvironmentVariable("PUSHOVER__USER__KEY")
      );

      return response.Status;
    }
  }
}