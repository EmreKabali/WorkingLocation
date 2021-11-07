using Entity.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
   public class WorkLogType:ModelBase
    {
        public string WorkLogTypeName { get; set; }
        public string Description { get; set; }
    }
}
