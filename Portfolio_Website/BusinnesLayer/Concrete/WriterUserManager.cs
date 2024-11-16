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
    public class WriterUserManager : IWriterUserService
    {
        IWriterUserDal _writeruserdal;
        public WriterUserManager(IWriterUserDal writerUserDal)
        {
            _writeruserdal = writerUserDal;
        }

        public void TAdd(WriterUser t)
        {
            _writeruserdal.Insert(t);
        }

        public void TDelete(WriterUser t)
        {
             _writeruserdal.Delete(t);
        }

        public WriterUser TGetByID(int id)
        {
            return _writeruserdal.GetById(id);
        }

        public List<WriterUser> TGetList()
        {
            return _writeruserdal.GetList();
        }

        public void TUpdate(WriterUser t)
        {
            _writeruserdal.Update(t);
        }
    }
}
