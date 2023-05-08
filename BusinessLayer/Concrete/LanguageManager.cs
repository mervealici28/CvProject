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
    public class LanguageManager : ILanguageService
    {
        ILanguageDal _languageDal;

        public LanguageManager(ILanguageDal languageDal)
        {
            _languageDal = languageDal;
        }

        public List<Language> GetList()
        {
            return _languageDal.GetListAll();
        }

        public void TAdd(Language t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Language t)
        {
            throw new NotImplementedException();
        }

        public Language TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Language t)
        {
            throw new NotImplementedException();
        }
    }
}
