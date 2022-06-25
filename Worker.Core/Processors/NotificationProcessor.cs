using System;
using PushoverClient;
using Worker.Core.Services;

namespace Worker.Core
{
  public class NotificationProcessor
  {
    private INotificationService _service;

    public NotificationProcessor(INotificationService notificationService)
    {
      _service = notificationService;
    }

    public bool SendNotification(NotificationRequest request)
    {
      try
      {
        var response = _service.SendPushOverAPI(request);
        if(response == 1)
        {
          return true;
        } else
        {
          return false;
        }
      }
      catch (Exception e)
      {
        return false;
      }
    }
  }
}