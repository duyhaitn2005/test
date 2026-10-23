using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace test.Controllers
{
    public class hello : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 5)
        {
            ViewBag.Message = "Hello" + name;
            ViewData["numTimes"] = numTimes;
            return View();
        }
    }
}
