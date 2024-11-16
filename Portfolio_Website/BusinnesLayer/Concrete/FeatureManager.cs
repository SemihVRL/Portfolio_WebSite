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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featuredal;
        public FeatureManager(IFeatureDal featureDal)
        {
                _featuredal = featureDal;
        }
        public void TAdd(Feature t)
        {
           _featuredal.Insert(t);
        }

        public void TDelete(Feature t)
        {
           _featuredal.Delete(t);
        }

        public Feature TGetByID(int id)
        {
            return _featuredal.GetById(id);
        }

        public List<Feature> TGetList()
        {
            return _featuredal.GetList();
        }

        public void TUpdate(Feature t)
        {
          _featuredal.Update(t);
        }
    }
}
