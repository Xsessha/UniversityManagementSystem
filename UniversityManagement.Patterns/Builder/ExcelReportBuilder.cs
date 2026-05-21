namespace UniversityManagement.Patterns.Builder;

public class ExcelReportBuilder
    : ReportBuilder
{
    public override void BuildHeader()
    {
        _report +=
            "===== EXCEL REPORT =====\n";
    }

    public override void BuildBody()
    {
        _report +=
            "Attendance and analytics data\n";
    }

    public override void BuildFooter()
    {
        _report +=
            "===== END EXCEL REPORT =====";
    }
}