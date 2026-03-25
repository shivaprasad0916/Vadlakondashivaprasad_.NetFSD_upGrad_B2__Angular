using System;
using System.Collections.Generic;
using System.Text;

// Common interface for all notification services
public interface INotificationService
{
    void Send(string message);
}

// Concrete services
public class EmailService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"[EmailService] Sending Email: {message}");
    }
}

public class SMSService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"[SMSService] Sending SMS: {message}");
    }
}

public class PushService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"[PushService] Sending Push Notification: {message}");
    }
}
