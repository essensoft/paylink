using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AccessParams Data Structure.
    /// </summary>
    public class AccessParams : AlipayObject
    {
        /// <summary>
        /// 目前支持以下值：  1. ALIPAYAPP  （钱包h5页面签约）  2. QRCODE(扫码签约)  3. QRCODEORSMS(扫码签约或者短信签约)
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }
    }
}
