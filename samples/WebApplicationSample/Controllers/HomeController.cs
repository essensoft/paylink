using System.Diagnostics;
using System.Drawing;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using WebApplicationSample.Models;

namespace WebApplicationSample.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 前言
        /// </summary>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 生成二维码SVG
        /// </summary>
        /// <param name="data"></param>
        /// <param name="size"></param>
        [HttpGet]
        public IActionResult QrCode(string data, int size = 168)
        {
            using (var qrGenerator = new QRCodeGenerator())
            using (var qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.L))
            using (var svgQrCode = new SvgQRCode(qrCodeData))
            {
                var svgText = svgQrCode.GetGraphic(new Size(size, size));
                return File(Encoding.UTF8.GetBytes(svgText), "text/xml");
            }
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
