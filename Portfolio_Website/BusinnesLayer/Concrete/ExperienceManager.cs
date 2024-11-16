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
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _exmanagerdal;
        public ExperienceManager(IExperienceDal exmanagerdal)
        {
            _exmanagerdal = exmanagerdal;
        }
        public void TAdd(Experience t)
        {
            _exmanagerdal.Insert(t);
        }

        public void TDelete(Experience t)
        {
          _exmanagerdal.Delete(t);
        }

        public object TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Experience TGetByID(int id)
        {
            return _exmanagerdal.GetById(id);

        }

        public List<Experience> TGetList()
        {
            return _exmanagerdal.GetList();
        }

        public void TUpdate(Experience t)
        {
            _exmanagerdal.Update(t);
        }
    }
}
