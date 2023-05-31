var dataTable

$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $('#myTable').DataTable({
        "ajax": {
            "url": "/Station/GetAll"
        },
        "columns": [
            { "data": "name", "width": "60%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div class="w-75">
                            <a href="/Station/Details?id=${data}"
                            class="btn btn-primary mx-1">
                                Details
                            </a>
                        </div>
                    `
                }, "width": "40%"
            }
        ]
    });
}
