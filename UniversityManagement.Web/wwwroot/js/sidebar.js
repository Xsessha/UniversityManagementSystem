const sidebarLinks =
    document.querySelectorAll(".sidebar-menu a");

sidebarLinks.forEach(link => {

    link.addEventListener("click", () => {

        sidebarLinks.forEach(l =>
            l.classList.remove("active"));

        link.classList.add("active");

    });

});