using System;
using System.Collections.Generic;
using System.Text;

class Program6
{
    static void Main()
    {
        string[] channels = { "email", "sms", "push" };

        foreach (string channel in channels)
        {
            INotificationService service = NotificationFactory.CreateNotification(channel);
            service.Send($"Welcome to InventoryApp! (via {channel.ToUpper()})");
        }
    }
}