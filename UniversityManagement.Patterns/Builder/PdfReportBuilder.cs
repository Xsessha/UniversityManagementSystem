namespace UniversityManagement.Patterns.Builder;

public class PdfReportBuilder
    : ReportBuilder
{
    public override void BuildHeader()
    {
        _report +=
            "===== PDF REPORT =====\n";
    }

    public override void BuildBody()
    {
        _report +=
            "Student statistics and ratings\n";
    }

    public override void BuildFooter()
    {
        _report +=
            "===== END PDF REPORT =====";
    }
}