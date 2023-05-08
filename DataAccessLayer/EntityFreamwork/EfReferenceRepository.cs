using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFreamwork
{
    public class EfReferenceRepository:GenericRepository<Reference>,IReferenceDal
    {
    }
}
