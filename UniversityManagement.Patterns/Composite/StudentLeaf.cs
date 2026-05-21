namespace UniversityManagement.Patterns.Composite;

public class StudentLeaf
    : IUniversityComponent
{
    public string FullName { get; set; }

    public StudentLeaf(string fullName)
    {
        FullName = fullName;
    }

    public string GetName()
    {
        return FullName;
    }

    public void Display(int depth)
    {
        Console.WriteLine(
            new string('-', depth) +
            $" Student: {FullName}");
    }
}