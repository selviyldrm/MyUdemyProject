﻿using HotelProject.BusinessLAaer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLAaer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public AppUser GetByID(int id)
        {
           return _appUserDal.GetByID(id);
        }

        public List<AppUser> GetList()
        {
            return _appUserDal.GetList();
        }

        public int TappUserCount()
        {
            return _appUserDal.appUserCount();
        }

        public void TDelete(AppUser t)
        {
            _appUserDal.Delete(t);
        }

        public void TInsert(AppUser t)
        {
            _appUserDal.Insert(t);
        }

        public void TUpdate(AppUser t)
        {
            _appUserDal.Update(t);
        }

        public List<AppUser> TUserListWithWorkLocation()
        {
           return _appUserDal.UserListWithWorkLocation();
        }

        public List<AppUser> TUsersListWithWorkLocations()
        {
            return _appUserDal.UsersListWithWorkLocations();
        }
    }
}
