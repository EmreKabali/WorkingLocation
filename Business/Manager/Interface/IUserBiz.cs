using Entity.DTO.RequestDTO;
using Entity.DTO.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager.Interface
{
    public interface IUserBiz
    {
        UserResponse GetById(int id);

        UserResponse GetByFilter(UserRequest request);

        UserResponse GetList();


        UserResponse Add(UserRequest request);

        Task<UserResponse> AddAsync(UserRequest request);

        UserResponse Update(UserRequest request);

        Task<UserResponse> UpdateAsync(UserRequest request);


        void Delete(UserRequest request);

        Task DeleteAsync(UserRequest request);
        
    }
}
