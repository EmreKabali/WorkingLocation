﻿using Entity.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Department:ModelBase
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
