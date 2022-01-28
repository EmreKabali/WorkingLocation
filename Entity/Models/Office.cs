using Entity.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
   public class Office:ModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
        public int MaximumCapacity { get; set; }

        public virtual Location Location { get; set; }

    }
}
