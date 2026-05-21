namespace UniversityManagement.Patterns.Composite;

public class FacultyComposite
    : IUniversityComponent
{
    private readonly List<IUniversityComponent>
        _components = new();

    public string Name { get; set; }

    public FacultyComposite(string name)
    {
        Name = name;
    }

    public void Add(
        IUniversityComponent component)
    {
        _components.Add(component);
    }

    public string GetName()
    {
        return Name;
    }

    public void Display(int depth)
    {
        Console.WriteLine(
            new string('-', depth) +
            $" Faculty: {Name}");

        foreach (var component in _components)
        {
            component.Display(depth + 2);
        }
    }
}