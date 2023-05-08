using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.ViewComponents.Reference
{
    public class Reference:ViewComponent
    {
        ReferenceManager em = new ReferenceManager(new EfReferenceRepository());
        public IViewComponentResult Invoke()
        {
            var values = em.GetList();
            return View(values);
        }
    }
}
