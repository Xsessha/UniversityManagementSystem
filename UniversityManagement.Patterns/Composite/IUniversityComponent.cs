namespace UniversityManagement.Patterns.Composite;

public interface IUniversityComponent
{
    string GetName();

    void Display(int depth);
}