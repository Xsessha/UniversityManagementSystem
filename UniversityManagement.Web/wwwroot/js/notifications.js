const connection =
    new signalR.HubConnectionBuilder()
        .withUrl("/notificationHub")
        .build();

connection.on(
    "ReceiveNotification",
    (title, message) => {

        const notification =
            document.createElement("div");

        notification.className =
            "alert alert-info";

        notification.innerHTML =
            `<strong>${title}</strong><br>${message}`;

        document.body.appendChild(notification);

        setTimeout(() => {
            notification.remove();
        }, 5000);
    });

connection.start();