using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplicationSample.Models;

namespace WebApplicationSample.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 前言
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 打赏
        /// </summary>
        /// <returns></returns>
        public IActionResult Gratuity()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
