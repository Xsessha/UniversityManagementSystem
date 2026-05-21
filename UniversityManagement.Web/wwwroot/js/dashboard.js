document.addEventListener(
    "DOMContentLoaded",
    () => {

        const cards =
            document.querySelectorAll(
                ".dashboard-card"
            );

        cards.forEach(card => {

            card.addEventListener(
                "mouseenter",
                () => {

                    card.style.transform =
                        "scale(1.03)";

                });

            card.addEventListener(
                "mouseleave",
                () => {

                    card.style.transform =
                        "scale(1)";

                });

        });

    });