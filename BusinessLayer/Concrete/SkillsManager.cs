using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SkillsManager : ISkillsService
    {
        ISkillsDal _skillsDal;

        public SkillsManager(ISkillsDal skillsDal)
        {
            _skillsDal = skillsDal;
        }

        public List<Skills> GetList()
        {
            return _skillsDal.GetListAll();
        }

        public void TAdd(Skills t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Skills t)
        {
            throw new NotImplementedException();
        }

        public Skills TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Skills t)
        {
            throw new NotImplementedException();
        }
    }
}
