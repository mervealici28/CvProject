using BusinessLayer.Concrete;
using BusinessLayer.Globals.MailQue;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CvProject.Controllers
{
    [Authorize]
    public class ContactController : _BaseController
    {
        private IMailQue _mailQue;
        private string _secretKey;
        private string _userName = "";
        private string _password = "";
        private readonly IConfiguration _configuration; // appsetting.json dosayası içerisindeki verileri okumak için eklendi.
        ContactManager cm = new ContactManager(new EfContactRepository());
        public ContactController(IConfiguration configuration)
        {
            _configuration = configuration;
            _secretKey = _configuration.GetSection("GoogleReCaptcha").GetSection("SecretKey").Value;
            _mailQue = new MailQue();
            _userName = _configuration.GetSection("MailQue").GetSection("Username").Value;
            _password = _configuration.GetSection("MailQue").GetSection("Password").Value;
        }


        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Response = TempData["ResponseMessage"];
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Contact p)
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
                return Redirect("/Contact");
            }
#endif
            #endregion
            var body = "Ad Soyad: " + p.ContactUserName + "<br>";
            body += "Email: " + p.ContactMail + "<br>";
            body += "Mesaj: " + p.ContactMessage + "<br>";

            var response = _mailQue.SendMail("smtp-mail.outlook.com", "merve.alici@autoking.com.tr", "mervealici2817@outlook.com", "Selam", "İletişim Formu Dolduruldu !", body, _userName, _password);


            p.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.ContactStatus = true;
            p.ContactIp = HttpContext.Connection.RemoteIpAddress.ToString();
            cm.ContactAdd(p);
            return RedirectToAction("Index", "About");
        }
    }
}
