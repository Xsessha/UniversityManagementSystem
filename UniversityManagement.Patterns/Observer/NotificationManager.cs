namespace UniversityManagement.Patterns.Observer;

public class NotificationManager
{
    private readonly TeacherSubject
        _teacherSubject = new();

    public void Subscribe(
        NotificationObserver observer)
    {
        _teacherSubject.Attach(observer);
    }

    public void SendNotification(
        string message)
    {
        _teacherSubject.Notify(message);
    }
}