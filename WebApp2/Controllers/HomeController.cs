using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebApp2.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index(string id)
        {
            if (id == "bug")
            {
                throw new Exception("you asked for it");
            }
            if (id == "google")
            {
                var httpClient = new HttpClient();
                var result = await httpClient.GetAsync("http://google.com");
                var s = await result.Content.ReadAsStringAsync();
                return Content(s);
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}