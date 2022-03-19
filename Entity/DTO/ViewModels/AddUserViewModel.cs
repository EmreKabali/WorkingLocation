using Entity.DTO.AddModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages.Html;

namespace Entity.DTO.ViewModels
{
    public class AddUserViewModel
    {
       public  List<SelectListItem> managerList { get; set; }

       public  AddUserModel addUserModel { get; set; }

    }
}
