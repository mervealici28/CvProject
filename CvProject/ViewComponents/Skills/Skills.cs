using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.ViewComponents.Skills
{
    public class Skills : ViewComponent
    {
        SkillsManager em = new SkillsManager(new EfSkillsRepository());
        public IViewComponentResult Invoke()
        {
            var values = em.GetList();
            return View(values);
        }
    }
}
