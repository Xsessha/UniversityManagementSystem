namespace UniversityManagement.Patterns.Builder;

public abstract class ReportBuilder
{
    protected string _report = string.Empty;

    public abstract void BuildHeader();

    public abstract void BuildBody();

    public abstract void BuildFooter();

    public string GetReport()
    {
        return _report;
    }
}