using Business.Manager.Interface;
using DataAccess.Repositories.Interface;
using Entity.DTO.RequestDTO;
using Entity.DTO.ResponseDTO;
using Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager
{
    public class DepartmentBiz : IDepartmentBiz
    {
        private readonly IDepartmentRepository _repository;

        public DepartmentBiz(IDepartmentRepository repository)
        {
            _repository = repository;
        }
        public DepartmentResponse Add(DepartmentRequest request)
        {
            var response = new DepartmentResponse { Entity = new Entity.Models.Department(), Error = new Entity.DTO.Error() };
            try
            {
                request.Entity.Status = (int)Status.Active;
                request.Entity.AddedDate = DateTime.Now;
                //request.Entity.AddedBy=addedUser
                response.Entity = _repository.Add(request.Entity);
            }
            catch (Exception ex)
            {
                response.Error.HasException = true;
                response.Error.ErrorMessage = ex.Message;
            }

            return response;
        }

        public Task<DepartmentResponse> AddAsync(DepartmentRequest request)
        {
            throw new NotImplementedException();
        }

        public void Delete(DepartmentRequest request)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(DepartmentRequest request)
        {
            throw new NotImplementedException();
        }

        public DepartmentResponse GetByFilter(DepartmentRequest request)
        {
            throw new NotImplementedException();
        }

        public DepartmentResponse GetById(int id)
        {
            throw new NotImplementedException();
        }

        public DepartmentResponse GetList()
        {
            throw new NotImplementedException();
        }

        public DepartmentResponse Update(DepartmentRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DepartmentResponse> UpdateAsync(DepartmentRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
