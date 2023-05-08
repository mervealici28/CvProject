using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Controllers
{
    public class AboutController : _BaseController
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
