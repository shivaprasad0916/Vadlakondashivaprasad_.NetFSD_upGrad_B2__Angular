using System;
using System.Collections.Generic;
using System.Text;

// Factory - decides which service to create
public class NotificationFactory
{
    public static INotificationService CreateNotification(string type)
    {
        switch (type.ToLower())
        {
            case "email": return new EmailService();
            case "sms": return new SMSService();
            case "push": return new PushService();
            default:
                throw new ArgumentException($"Unknown notification type: {type}");
        }
    }
}