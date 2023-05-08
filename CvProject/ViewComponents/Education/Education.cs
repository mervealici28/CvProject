using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.ViewComponents.Education
{
    public class Education : ViewComponent
    {
        EducationManager em = new EducationManager(new EfEducationRepository());
        public IViewComponentResult Invoke()
        {
            var values = em.GetList();
            return View(values);
        }
    }
}

