using System.Drawing;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QRCoder;

namespace WebApplicationSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QRCodeController : ControllerBase
    {
        private readonly ILogger<QRCodeController> _logger;

        public QRCodeController(ILogger<QRCodeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// 生成二维码SVG
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="size">尺寸</param>
        [HttpGet]
        public IActionResult GetQRCode(string data, int size = 180)
        {
            using (var qrGenerator = new QRCodeGenerator())
            using (var qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.L))
            using (var svgQrCode = new SvgQRCode(qrCodeData))
            {
                var svgText = svgQrCode.GetGraphic(new Size(size, size), false, SvgQRCode.SizingMode.WidthHeightAttribute);
                return File(Encoding.UTF8.GetBytes(svgText), "image/svg+xml");
            }
        }
    }
}
