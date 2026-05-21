const ctx =
    document.getElementById('ratingChart');

if (ctx) {

    new Chart(ctx, {

        type: 'bar',

        data: {

            labels: [
                'CS-21',
                'CS-22',
                'CS-23',
                'CS-24'
            ],

            datasets: [{

                label: 'Average Rating',

                data: [91, 85, 78, 96],

                borderWidth: 1

            }]
        },

        options: {

            responsive: true,

            scales: {

                y: {
                    beginAtZero: true
                }

            }

        }

    });

}