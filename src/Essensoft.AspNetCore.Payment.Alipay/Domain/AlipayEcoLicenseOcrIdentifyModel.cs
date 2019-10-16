using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoLicenseOcrIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoLicenseOcrIdentifyModel : AlipayObject
    {
        /// <summary>
        /// 图片字节byte[]经过base64处理的字符串
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }
    }
}
