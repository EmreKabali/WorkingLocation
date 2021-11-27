﻿using Business.Manager.Interface;
using DataAccess.Repositories.Interface;
using Entity.DTO.RequestDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager
{
    public class MenuBiz : IMenuBiz
    {
        IMenuRepository menuRepository;
        public MenuBiz(IMenuRepository menuRepository)
        {
            this.menuRepository = menuRepository;
        }
        public MenuResponse Add(MenuRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<MenuResponse> AddAsync(MenuRequest request)
        {
            throw new NotImplementedException();
        }

        public void Delete(MenuRequest request)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(MenuRequest request)
        {
            throw new NotImplementedException();
        }

        public MenuResponse GetByFilter(MenuRequest request)
        {
            throw new NotImplementedException();
        }

        public MenuResponse GetById(int id)
        {
            throw new NotImplementedException();
        }

        public MenuResponse GetList()
        {
            var menuResponse = new MenuResponse();

            menuResponse.EntityList = menuRepository.GetMenuWithSubMenu();

            return menuResponse;
        }

        public MenuResponse Update(MenuRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<MenuResponse> UpdateAsync(MenuRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
