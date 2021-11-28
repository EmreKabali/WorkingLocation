using Business.Manager.Interface;
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
    public class WorkLogTypeBiz : IWorkLogTypeBiz
    {
        IWorkLogTypeRepository repository;
        public WorkLogTypeBiz(IWorkLogTypeRepository repository)
        {
            this.repository = repository;
        }
        public WorkLogTypeResponse Add(WorkLogTypeRequest request)
        {
            var response = new WorkLogTypeResponse();

            response.Entity = repository.Add(request.Entity);
            return response;
        }

        public Task<WorkLogTypeResponse> AddAsync(WorkLogTypeRequest request)
        {
            throw new NotImplementedException();
        }

        public void Delete(WorkLogTypeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(WorkLogTypeRequest request)
        {
            throw new NotImplementedException();
        }

        public WorkLogTypeResponse GetByFilter(WorkLogTypeRequest request)
        {
            throw new NotImplementedException();
        }

        public WorkLogTypeResponse GetById(int id)
        {
            throw new NotImplementedException();
        }

        public WorkLogTypeResponse GetList()
        {
            var response = new WorkLogTypeResponse();
            response.EntityList = repository.GetAll();

            return response;

        }

        public WorkLogTypeResponse Update(WorkLogTypeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<WorkLogTypeResponse> UpdateAsync(WorkLogTypeRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
