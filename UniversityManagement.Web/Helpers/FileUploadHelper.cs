using Microsoft.AspNetCore.Http;

namespace UniversityManagement.Web.Helpers;

public static class FileUploadHelper
{
    public static async Task<string?> UploadImageAsync(
        IFormFile file,
        string rootPath,
        string folder)
    {
        if (file == null || file.Length == 0)
            return null;

        var uploadsFolder =
            Path.Combine(rootPath, "uploads", folder);

        if (!Directory.Exists(uploadsFolder))
        {
            Directory.CreateDirectory(uploadsFolder);
        }

        var uniqueFileName =
            $"{Guid.NewGuid()}_{file.FileName}";

        var filePath =
            Path.Combine(uploadsFolder, uniqueFileName);

        using var stream =
            new FileStream(filePath, FileMode.Create);

        await file.CopyToAsync(stream);

        return $"/uploads/{folder}/{uniqueFileName}";
    }
}