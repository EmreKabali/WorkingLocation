using Business.Manager.Interface;
using DataAccess.Repositories;
using DataAccess.Repositories.Interface;
using Entity.DTO.RequestDTO;
using Entity.DTO.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager
{
    public class WorkLogBiz : IWorkLogBiz
    {

        IWorkLogRepository repository;

        public WorkLogBiz(IWorkLogRepository repository)
        {
            this.repository = repository;

        }
        public WorkLogResponse Add(WorkLogRequest request)
        {
            var response = new WorkLogResponse();

            response.Entity=repository.Add(request.Entity);

            return response;

        }

        public Task<WorkLogResponse> AddAsync(WorkLogRequest request)
        {
            throw new NotImplementedException();
        }

        public void Delete(WorkLogRequest request)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(WorkLogRequest request)
        {
            throw new NotImplementedException();
        }

        public WorkLogResponse GetByFilter(WorkLogRequest request)
        {
            throw new NotImplementedException();
        }

        public WorkLogResponse GetById(int id)
        {
            throw new NotImplementedException();
        }

        public WorkLogResponse GetList()
        {
            throw new NotImplementedException();
        }

        public WorkLogResponse Update(WorkLogRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<WorkLogResponse> UpdateAsync(WorkLogRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
