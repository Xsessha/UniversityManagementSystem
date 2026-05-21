using Microsoft.AspNetCore.SignalR;

namespace UniversityManagement.Web.Hubs;

public class NotificationHub : Hub
{
    public async Task SendNotification(
        string title,
        string message)
    {
        await Clients.All.SendAsync(
            "ReceiveNotification",
            title,
            message);
    }

    public async Task StudentJoined(string studentName)
    {
        await Clients.All.SendAsync(
            "StudentJoined",
            studentName);
    }

    public async Task LessonCreated(string lessonName)
    {
        await Clients.All.SendAsync(
            "LessonCreated",
            lessonName);
    }
}