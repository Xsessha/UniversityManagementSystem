using UniversityManagement.Core.Interfaces;

namespace UniversityManagement.Patterns.Observer;

public class NotificationObserver
    : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine(
            $"Notification: {message}");
    }
}