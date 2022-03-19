using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO.AddModels
{
    public class AddUserModel
    {
        public string RegisterNumber { get; set; }

        public string IdentityNumber { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public string Address { get; set; }

        public DateTime JobStartDate { get; set; }

        public int TitleId { get; set; }


        public int DepartmantId { get; set; }

        public int ManagerId { get; set; }

    }
}
