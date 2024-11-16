using BusinnesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class SchoolManager : ISchoolService
    {
        ISchoolDal _schooldal;
        public SchoolManager(ISchoolDal schoolDal)
        {
            _schooldal = schoolDal;
        }
        public void TAdd(School t)
        {
           _schooldal.Insert(t);
        }

        public void TDelete(School t)
        {
            _schooldal.Delete(t);
        }

        public School TGetByID(int id)
        {
            return _schooldal.GetById(id);
        }

        public List<School> TGetList()
        {
            return _schooldal.GetList();
        }

        public void TUpdate(School t)
        {
            _schooldal.Update(t);
        }
    }
}
