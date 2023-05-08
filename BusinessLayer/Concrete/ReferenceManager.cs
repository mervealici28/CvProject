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
    public class ReferenceManager : IReferenceService
    {
        IReferenceDal _referenceDal;

        public ReferenceManager(IReferenceDal referenceDal)
        {
            _referenceDal = referenceDal;
        }

        public List<Reference> GetList()
        {
            return _referenceDal.GetListAll();
        }

        public void TAdd(Reference t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Reference t)
        {
            throw new NotImplementedException();
        }

        public Reference TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reference t)
        {
            throw new NotImplementedException();
        }
    }
}
