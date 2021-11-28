

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
                $("#exampleModal").modal('show');
                
                
            },



        });
        calendar.render();
    });
  
};




