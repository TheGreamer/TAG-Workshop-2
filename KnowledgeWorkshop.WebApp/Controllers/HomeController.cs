using KnowledgeWorkshop.WebApp.Helpers;
using KnowledgeWorkshop.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KnowledgeWorkshop.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> GetJsonData(string dataUrl)
        {
            List<Product> products = await ApiHelper.SendHttpGetRequest<Product>(dataUrl);
            return Json(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}