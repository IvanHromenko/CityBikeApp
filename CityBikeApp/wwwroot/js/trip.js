var dataTable

$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $('#tripTable').DataTable({
        "ajax": {
            "url": "/Home/GetTrips"
        },
        "columns": [
            { "data": "departurestationname", "width": "20%" },
            { "data": "returnstationname", "width": "20%" },
            {
                "data": "covereddistancem",
                "render": function (data) {
                    return data / 1000;
                },
                "width": "20%"
            },
            {
                "data": "durationsec",
                "render": function (data) {
                    return data / 60;
                },
                "width": "20%"
            }
            
        ]
    });
}
