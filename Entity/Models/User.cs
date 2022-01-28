using Entity.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class User : ModelBase
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

        public string Token { get; set; }
        public DateTime? TokenExprationDate { get; set; }

        public virtual Title Title { get; set; }
        public virtual Department Department { get; set; }
      

    }
}
