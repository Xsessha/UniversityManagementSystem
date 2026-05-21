using UniversityManagement.Core.Interfaces;

namespace UniversityManagement.Patterns.Observer;

public class TeacherSubject
    : ISubject
{
    private readonly List<IObserver>
        _observers = new();

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (var observer in _observers)
        {
            observer.Update(message);
        }
    }
}