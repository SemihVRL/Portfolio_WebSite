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
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfoliodal;
        public PortfolioManager(IPortfolioDal portfolioDal)
        {
                _portfoliodal = portfolioDal;
        }
        public void TAdd(Portfolio t)
        {
            _portfoliodal.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            _portfoliodal.Delete(t);
        }

        public Portfolio TGetByID(int id)
        {
            return _portfoliodal.GetById(id);   
        }

        public List<Portfolio> TGetList()
        {
            return _portfoliodal.GetList();
        }

        public void TUpdate(Portfolio t)
        {
            _portfoliodal.Update(t);
        }
    }
}
