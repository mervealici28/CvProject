using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.ViewComponents.Experience
{
    public class Experience : ViewComponent
    {
        ExperienceManager em = new ExperienceManager(new EfExperienceRepository());
        public IViewComponentResult Invoke()
        {
            var values = em.GetList();
            return View(values);
        }
    }
}
