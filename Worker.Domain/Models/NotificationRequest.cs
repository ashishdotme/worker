using System;

namespace Worker.Core
{
  public class NotificationRequest
  {
    public DateTime Date { get; set; }
    public string Application { get; set; }
    public string Message { get; set; }
  }
}