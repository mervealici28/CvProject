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
    public class EducationManager : IEducationService
    {
        IEducationDal _educationDal;

        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public List<Education> GetList()
        {
            return _educationDal.GetListAll();
        }

        public void TAdd(Education t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Education t)
        {
            throw new NotImplementedException();
        }

        public Education TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Education t)
        {
            throw new NotImplementedException();
        }
    }
}
