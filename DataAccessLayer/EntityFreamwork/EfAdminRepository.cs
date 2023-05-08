using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFreamwork
{
    public class EfAdminRepository : GenericRepository<Admin>, IAdminDal
    {
    }
}
