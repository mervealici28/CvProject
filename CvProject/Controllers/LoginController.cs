using CvProject.Dto;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CvProject.Controllers
{
    public class LoginController : _BaseController
    {
        private string _secretKey;
        private readonly IConfiguration _configuration; // appsetting.json dosayası içerisindeki verileri okumak için eklendi.
        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
            _secretKey = _configuration.GetSection("GoogleReCaptcha").GetSection("SecretKey").Value;

        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewBag.Response = TempData["ResponseMessage"];
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(LoginDto p)
        {
            if (ModelState.IsValid)
            {
                #region Recaptcha
#if !DEBUG
                //Google Recaptcha Kontrolü
                var captchaImage = HttpContext.Request.Form["g-recaptcha-response"];
                var verified = await CheckCaptcha(_secretKey);
                if (!verified || string.IsNullOrEmpty(captchaImage))
                {
                    ModelState.AddModelError(string.Empty, "Robot olmadığınızı Kanıtlayın!");
                    TempData["ResponseMessage"] = string.Join('|', ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
                    return Redirect("/Login");
                }
#endif
                #endregion

                Context c = new Context();
                var datavalue = c.Admins.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);
                if (datavalue != null)
                {
                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.Username)
                };
                    var useridentity = new ClaimsIdentity(claims, "a");
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "About");
                }
                else
                {
                    return View();
                }
            }
            return View();


        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
    }
}
