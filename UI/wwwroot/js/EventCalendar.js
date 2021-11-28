

function OpenCalendar() {

    document.addEventListener('DOMContentLoaded', function () {
        var calendarEl = document.getElementById('calendar');
        var calendar = new FullCalendar.Calendar(calendarEl, {
            initialView: 'dayGridMonth',
            headerToolbar: {
                left: 'prev,next today',
                center: 'title',
                right: 'dayGridMonth,timeGridWeek,timeGridDay'
            },
            selectable: true,
            select: function OpenModal(selectInfo) {


                var startdate = selectInfo.startStr;
                var endDate = selectInfo.endStr;
                $('#eventStartDate').val(startdate);
                $('#eventEndDate').val(endDate);
                $("#createEventModal").modal('show');


            },



        });
        calendar.render();
    });

};

function SaveEvent() {



};

function LoadWorkLogType() {

    $.ajax({
        type: "GET",
        url: "/WorkLog/LoadWorkLogTypes",
        success: function (data) {
           
            if (data != null) {

                $.each(data, function (key, value) {

                    console.log(key);
                    console.log(value);
                    $('#eventWorkLogType')
                        .append($("<option></option>")
                            .attr("value", value.id)
                            .text(value.workLogTypeName));
                });
            }
        },
        error: function (err) {

        }
    });


};




