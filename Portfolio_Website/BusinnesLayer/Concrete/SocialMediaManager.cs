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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _media;
        public SocialMediaManager(ISocialMediaDal media)
        {
                _media = media;
        }
        public void TAdd(SocialMedia t)
        {
            _media.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            _media.Delete(t);
        }

        public SocialMedia TGetByID(int id)
        {
            return _media.GetById(id);
        }

        public List<SocialMedia> TGetList()
        {
            return _media.GetList();
        }

        public void TUpdate(SocialMedia t)
        {
           _media.Update(t);
        }
    }
}
