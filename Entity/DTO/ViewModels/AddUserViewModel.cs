using Entity.DTO.AddModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Entity.DTO.ViewModels
{
    public class AddUserViewModel
    {
       public  List<SelectListItem> managerList { get; set; }

        public string RegisterNumber { get; set; }

        public string IdentityNumber { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public string Address { get; set; }

        public DateTime JobStartDate { get; set; }

        public int TitleId { get; set; }


        public int DepartmantId { get; set; }

        public int ManagerId { get; set; }

        public string Password { get; set; }
        public string Gender { get; set; }

        public string PhoneNumber { get; set; }

    }
}
