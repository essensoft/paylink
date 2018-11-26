using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicQrcodeCreateResponse.
    /// </summary>
    public class AlipayOpenPublicQrcodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 二维码图片地址，可跳转到实际图片
        /// </summary>
        [JsonProperty("code_img")]
        [XmlElement("code_img")]
        public string CodeImg { get; set; }

        /// <summary>
        /// 二维码有效时间，单位（秒）。永久码暂时忽略该信息
        /// </summary>
        [JsonProperty("expire_second")]
        [XmlElement("expire_second")]
        public string ExpireSecond { get; set; }
    }
}
