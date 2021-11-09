using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO.ResponseDTO
{
   public  class WorklogResponseDTO
    {

        public int WorkLogTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public UserResponseDTO User { get; set; }


        public string DayName { get; set; }

        public string Description { get; set; }

        public Office Office { get; set; }
    }
}
