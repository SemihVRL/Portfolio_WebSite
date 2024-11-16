using BusinnesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class SkillManager : ISkillService
    {
        ISkillDal _skill;
        public SkillManager(ISkillDal skillDal)
        {
                _skill = skillDal;
        }
        public void TAdd(Skill t)
        {
            _skill.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _skill.Delete(t);
        }

        public Skill TGetByID(int id)
        {
            return _skill.GetById(id);
        }

        public List<Skill> TGetList()
        {
            return _skill.GetList();
        }

        public void TUpdate(Skill t)
        {
           _skill.Update(t);
        }
    }
}
