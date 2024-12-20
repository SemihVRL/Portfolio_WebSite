﻿using BusinnesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutdal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutdal = aboutDal;
        }
        public void TAdd(About t)
        {
            _aboutdal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutdal.Delete(t);
        }

        public About TGetByID(int id)
        {
            return _aboutdal.GetById(id);
        }

        public List<About> TGetList()
        {
            return _aboutdal.GetList();
        }

        public void TUpdate(About t)
        {
            _aboutdal.Update(t);
        }
    }
}
