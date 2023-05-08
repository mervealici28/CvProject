using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.ViewComponents.Info
{
    public class Info : ViewComponent
    {
        AboutManager em = new AboutManager(new EfAboutRepository());
        public IViewComponentResult Invoke()
        {
            var values = em.GetList();
            return View(values);
        }
    }
}
