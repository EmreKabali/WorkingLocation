using Entity.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Title:ModelBase
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public virtual List<User> Users { get; set; }
    }
}
