using Entity.DTO.RequestDTO;
using Entity.DTO.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager.Interface
{
    public interface IWorkLogBiz
    {
        WorkLogResponse GetById(int id);

        WorkLogResponse GetByFilter(WorkLogRequest request);

        WorkLogResponse GetList();


        WorkLogResponse Add(WorkLogRequest request);

        Task<WorkLogResponse> AddAsync(WorkLogRequest request);

        WorkLogResponse Update(WorkLogRequest request);

        Task<WorkLogResponse> UpdateAsync(WorkLogRequest request);


        void Delete(WorkLogRequest request);

        Task DeleteAsync(WorkLogRequest request);
    }
}
