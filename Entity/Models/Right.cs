﻿using Entity.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Right:ModelBase
    {
        public int RoleId { get; set; }

        public int UserId { get; set; }



        public virtual User User { get; set; }

        public virtual Role Role { get; set; }
    }
}
