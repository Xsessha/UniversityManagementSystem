namespace UniversityManagement.Web.Helpers;

public static class ImageHelper
{
    public static string GetDefaultStudentImage()
    {
        return "/images/students/default.png";
    }

    public static string GetDefaultTeacherImage()
    {
        return "/images/teachers/default.png";
    }

    public static bool IsImage(string fileName)
    {
        var extensions = new[]
        {
            ".jpg",
            ".jpeg",
            ".png",
            ".gif",
            ".webp"
        };

        return extensions.Any(ext =>
            fileName.ToLower().EndsWith(ext));
    }
}