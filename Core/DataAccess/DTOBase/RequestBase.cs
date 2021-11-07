using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.DTOBase
{
    public class RequestBase<T>
    {
        public T Entity { get; set; }

        public List<T> EntityList { get; set; }

    }
}
