$(document).ready(function () {
    $('#datatable-clients').dataTable({
        responsive: true,
        "bPaginate": true,
        "sPaginationType": "full_numbers",
        "bSort": true,
        "aoColumnDefs": [{ "bSortable": false, "aTargets": [0] }],           // View is not sortable
        "aaSorting": [], 
        "iDisplayLength": 25,
        "pageLength": 25,
        "lengthChange": false,
    });

    $('#datatable-courses').dataTable({
        responsive: true,
        "bPaginate": true,
        "sPaginationType": "full_numbers",
        "bSort": true,
        "aoColumnDefs": [{ "bSortable": false, "aTargets": [0] }],           // View is not sortable
        "aaSorting": [],
        "iDisplayLength": 25,
        "pageLength": 25,
        "lengthChange": false,
    });

    $('#datatable-users').dataTable({
        responsive: true,
        "bPaginate": true,
        "sPaginationType": "full_numbers",
        "bSort": true,
        //"aoColumnDefs": [{ "bSortable": false, "aTargets": [0] }],           // View is not sortable
        "aaSorting": [],
        "iDisplayLength": 25,
        "pageLength": 25,
        "lengthChange": false,
    });




});