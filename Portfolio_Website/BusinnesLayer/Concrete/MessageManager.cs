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
    public class MessageManager : IMessageService
    {
        IMessageDal _ımessagedal;
        public MessageManager(IMessageDal messageDal)
        {
                _ımessagedal = messageDal;
        }
        public void TAdd(Message t)
        {
            _ımessagedal.Insert(t);
        }

        public void TDelete(Message t)
        {
            _ımessagedal.Delete(t);
        }

        public Message TGetByID(int id)
        {
            return _ımessagedal.GetById(id);
        }

        public List<Message> TGetList()
        {
           return _ımessagedal.GetList();
        }

        public void TUpdate(Message t)
        {
            _ımessagedal.Update(t);
        }
    }
}
