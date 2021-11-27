using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models.Base
{
   public  class ModelBase:IEntity
    {
        public int Id { get; set; }
        public int  Status { get; set; }
        public int AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public int? ChangedBy { get; set; }
        public int? ChangedDate { get; set; }

    }
}
