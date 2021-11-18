using Entity.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class SubMenuItems:ModelBase
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public string Path { get; set; }

        public string Paremeters { get; set; }

        public int ParentMenuId { get; set; }
    }
}
