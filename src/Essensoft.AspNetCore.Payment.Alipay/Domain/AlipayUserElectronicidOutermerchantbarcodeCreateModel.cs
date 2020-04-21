using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserElectronicidOutermerchantbarcodeCreateModel Data Structure.
    /// </summary>
    public class AlipayUserElectronicidOutermerchantbarcodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 码类型，可选值：动态二维码：DYNAMIC，静态二维码：STATIC
        /// </summary>
        [JsonPropertyName("barcode_type")]
        public string BarcodeType { get; set; }

        /// <summary>
        /// 过期时间，单位秒。仅当为动态码时，此属性有效。动态码最长有效期为2个小时，即7200秒。
        /// </summary>
        [JsonPropertyName("expire_time")]
        public long ExpireTime { get; set; }

        /// <summary>
        /// 商户类型。可选址为：网吧:CYBERCAFE,酒店宾馆:HOTEL,政务办事大厅:PUBLIC_SERVICE,机场:AIRPORT,长途客运:BUS,铁路:RAILWAY,景区:SCENIC_AREA,场馆:HALL,赛事/集会:GAME,快递邮寄:POST
        /// </summary>
        [JsonPropertyName("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 扫描商户码后的回跳链接
        /// </summary>
        [JsonPropertyName("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
