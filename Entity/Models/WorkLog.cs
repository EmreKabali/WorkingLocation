using Entity.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class WorkLog : ModelBase
    {

        public int WorkLogTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UserId { get; set; }
        public string DayName { get; set; }

        public string Description { get; set; }

        public int OfficeId { get; set; }

    }
}
