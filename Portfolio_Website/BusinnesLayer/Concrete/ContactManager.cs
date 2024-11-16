using BusinnesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactdal;
        public ContactManager(IContactDal contactDal)
        {
            _contactdal = contactDal;
        }

        public void TAdd(Contact t)
        {
             _contactdal.Insert(t);
        }

        public void TDelete(Contact t)
        {
            _contactdal.Delete(t);
        }

        public Contact TGetByID(int id)
        {
            return _contactdal.GetById(id);
             
        }

        public List<Contact> TGetList()
        {
            return _contactdal.GetList();
        }

        public void TUpdate(Contact t)
        {
            _contactdal.Update(t);
        }
    }
}
