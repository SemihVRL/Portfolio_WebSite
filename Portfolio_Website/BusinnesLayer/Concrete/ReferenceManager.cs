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
    public class ReferenceManager : IReferenceService
    {
        IReferenceDal _referenceservice;
        public ReferenceManager(IReferenceDal referenceService)
        {
                _referenceservice = referenceService;
        }
        public void TAdd(Reference t)
        {
            _referenceservice.Insert(t);  
        }

        public void TDelete(Reference t)
        {
            _referenceservice.Delete(t);
        }

        public Reference TGetByID(int id)
        {
            return _referenceservice.GetById(id);
        }

        public List<Reference> TGetList()
        {
            return _referenceservice.GetList();
        }

        public void TUpdate(Reference t)
        {
            _referenceservice.Update(t);
        }
    }
}
