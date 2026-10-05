namespace RefactoringLab;

public interface INotificationChannel
{
    void Send(string to, string message ,DateTime? sendAt);
}

public class Notification
{
    private bool urgent;
    private DateTime? sendAt;
    private INotificationChannel channel;

    public Notification(INotificationChannel notificationChannel, bool urgent = false, DateTime? sendAt = null)
    {
        channel = notificationChannel;
        this.urgent = urgent;
        this.sendAt = sendAt;
    }

    public void Send(string to, string message)
    {
        if (urgent)
        {
            message = $"[URGENT] {message}";
        }

        channel.Send(to, message, sendAt);
    }
}


public class EmailChannel : INotificationChannel
{
    public void Send(string to, string message, DateTime? sendAt)
    {
        if (sendAt.HasValue)
        {
            Console.WriteLine(
                $"[email scheduled {sendAt.Value:}] {to}: {message}");
        }
        else
        {
            Console.WriteLine($"[email] {to}: {message}");
        }
    }
}


public class SmsChannel : INotificationChannel
{
    public void Send(string to, string message, DateTime? sendAt)
    {
        if (sendAt.HasValue)
        {
            Console.WriteLine(
                $"[sms scheduled {sendAt.Value:}] {to}: {message}");
        }
        else
        {
            Console.WriteLine($"[sms] {to}: {message}");
        }
    }
}

public class WhatsAppChannel : INotificationChannel
{
    public void Send(string to, string message, DateTime? sendAt)
    {
        if (sendAt.HasValue)
        {
            Console.WriteLine(
                $"[whatsapp scheduled {sendAt.Value:}] {to}: {message}");
        }
        else
        {
            Console.WriteLine($"[whatsapp] {to}: {message}");
        }
    }
}
