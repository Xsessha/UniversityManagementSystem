namespace UniversityManagement.Patterns.Composite;

public class GroupComposite
    : IUniversityComponent
{
    private readonly List<IUniversityComponent>
        _students = new();

    public string Name { get; set; }

    public GroupComposite(string name)
    {
        Name = name;
    }

    public void Add(
        IUniversityComponent student)
    {
        _students.Add(student);
    }

    public string GetName()
    {
        return Name;
    }

    public void Display(int depth)
    {
        Console.WriteLine(
            new string('-', depth) +
            $" Group: {Name}");

        foreach (var student in _students)
        {
            student.Display(depth + 2);
        }
    }
}