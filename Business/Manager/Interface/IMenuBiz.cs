using Entity.DTO.RequestDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager.Interface
{
   public interface IMenuBiz
    {

        MenuResponse GetById(int id);

        MenuResponse GetByFilter(MenuRequest request);

        MenuResponse GetList();


        MenuResponse Add(MenuRequest request);

        Task<MenuResponse> AddAsync(MenuRequest request);

        MenuResponse Update(MenuRequest request);

        Task<MenuResponse> UpdateAsync(MenuRequest request);


        void Delete(MenuRequest request);

        Task DeleteAsync(MenuRequest request);
    }
}
