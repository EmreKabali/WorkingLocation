using Entity.DTO.RequestDTO;
using Entity.DTO.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager.Interface
{
   public interface IWorkLogTypeBiz
    {

        WorkLogTypeResponse GetById(int id);

        WorkLogTypeResponse GetByFilter(WorkLogTypeRequest request);

        WorkLogTypeResponse GetList();


        WorkLogTypeResponse Add(WorkLogTypeRequest request);

        Task<WorkLogTypeResponse> AddAsync(WorkLogTypeRequest request);

        WorkLogTypeResponse Update(WorkLogTypeRequest request);

        Task<WorkLogTypeResponse> UpdateAsync(WorkLogTypeRequest request);


        void Delete(WorkLogTypeRequest request);

        Task DeleteAsync(WorkLogTypeRequest request);
    }
}
