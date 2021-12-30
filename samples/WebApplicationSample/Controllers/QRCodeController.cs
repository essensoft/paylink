using Microsoft.AspNetCore.Mvc;
using QRCoder;

namespace WebApplicationSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QRCodeController : ControllerBase
    {
        /// <summary>
        /// 生成二维码SVG
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="size">尺寸</param>
        [HttpGet]
        public IActionResult GetQRCode(string data)
        {
            using (var qrGenerator = new QRCodeGenerator())
            using (var qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.L))
            using (var pngByteQrCode = new PngByteQRCode(qrCodeData))
            {
                var pngBytes = pngByteQrCode.GetGraphic(20, false);
                return File(pngBytes, "image/png");
            }
        }
    }
}
