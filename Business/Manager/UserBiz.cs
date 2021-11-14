using Business.Manager.Interface;
using Entity.DTO.RequestDTO;
using Entity.DTO.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager
{
    public class UserBiz : IUserBiz
    {


        public UserResponse Add(UserRequest request)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public UserResponse Update(UserRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<UserResponse> UpdateAsync(UserRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
