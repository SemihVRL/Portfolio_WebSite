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
    public class ServiceManager : IServiceService
    {
        IServiceDal _service;
        public ServiceManager(IServiceDal service)
        {
                _service = service;
        }
        public void TAdd(Service t)
        {
            _service.Insert(t);
        }

        public void TDelete(Service t)
        {
           _service.Delete(t);
        }

        public Service TGetByID(int id)
        {
           return _service.GetById(id);
        }

        public List<Service> TGetList()
        {
           return _service.GetList();
        }

        public void TUpdate(Service t)
        {
            _service.Update(t);
        }
    }
}
