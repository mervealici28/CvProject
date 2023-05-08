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
    public class InterestsManager : IInterestsService
    {
        IInterestsDal _interestsDal;

        public InterestsManager(IInterestsDal interestsDal)
        {
            _interestsDal = interestsDal;
        }

        public List<Interests> GetList()
        {
            return _interestsDal.GetListAll();
        }

        public void TAdd(Interests t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Interests t)
        {
            throw new NotImplementedException();
        }

        public Interests TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Interests t)
        {
            throw new NotImplementedException();
        }
    }
}
