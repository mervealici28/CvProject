using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CvProject.Controllers
{
    public class _BaseController : Controller
    {
        public _BaseController() { }

        [NonAction]
        protected async Task<bool> CheckCaptcha(string secretkey)
        {
            var postData = new List<KeyValuePair<string, string>>()
            {
            new KeyValuePair<string, string>("secret", secretkey),
            new KeyValuePair<string, string>("remoteip", HttpContext.Connection.RemoteIpAddress.ToString()),
            new KeyValuePair<string, string>("response", HttpContext.Request.Form["g-recaptcha-response"])
            };

            var client = new HttpClient();
            var response = await client.PostAsync("https://www.google.com/recaptcha/api/siteverify", new FormUrlEncodedContent(postData));

            var o = (JObject)JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());
            return (bool)o["success"];
        }
    }
}
