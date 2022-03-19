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
    public class UserBiz : IUserBiz
    {

        IUserRepository _repository;

        public UserBiz(IUserRepository repository)
        {
            _repository = repository;
        }
        public UserResponse Add(UserRequest request)
        {
            var response = new UserResponse { Entity = new Entity.Models.User(),Error=new Entity.DTO.Error() };
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

        public Task<UserResponse> AddAsync(UserRequest request)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserRequest request)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(UserRequest request)
        {
            throw new NotImplementedException();
        }

        public UserResponse GetByFilter(UserRequest request)
        {
            throw new NotImplementedException();
        }

        public UserResponse GetById(int id)
        {
            throw new NotImplementedException();
        }

        public UserResponse GetList()
        {
            var response = new UserResponse { EntityList = new List<Entity.Models.User>(), Error = new Entity.DTO.Error() };
            try
            {
                //TODO: should change field type of ChangeDate
                //request.Entity.ChangedDate = DateTime.Now;
                //request.Entity.ChangedBy=addedUser
                response.EntityList = _repository.GetAll(x=>x.Status==(int)Status.Active).ToList();
            }
            catch (Exception ex)
            {
                response.Error.HasException = true;
                response.Error.ErrorMessage = ex.Message;
            }

            return response;
        }

        public UserResponse Update(UserRequest request)
        {
            var response = new UserResponse { Entity = new Entity.Models.User(), Error = new Entity.DTO.Error() };
            try
            {
                //TODO: should change field type of ChangeDate
                //request.Entity.ChangedDate = DateTime.Now;
                //request.Entity.ChangedBy=addedUser
                response.Entity = _repository.Update(request.Entity);
            }
            catch (Exception ex)
            {
                response.Error.HasException = true;
                response.Error.ErrorMessage = ex.Message;
            }

            return response;
        }

        public Task<UserResponse> UpdateAsync(UserRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
