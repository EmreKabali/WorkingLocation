using Entity.DTO.RequestDTO;
using Entity.DTO.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager.Interface
{
    public interface IDepartmentBiz
    {
        DepartmentResponse GetById(int id);

        DepartmentResponse GetByFilter(DepartmentRequest request);

        DepartmentResponse GetList();


        DepartmentResponse Add(DepartmentRequest request);

        Task<DepartmentResponse> AddAsync(DepartmentRequest request);

        DepartmentResponse Update(DepartmentRequest request);

        Task<DepartmentResponse> UpdateAsync(DepartmentRequest request);


        void Delete(DepartmentRequest request);

        Task DeleteAsync(DepartmentRequest request);
    }
}
