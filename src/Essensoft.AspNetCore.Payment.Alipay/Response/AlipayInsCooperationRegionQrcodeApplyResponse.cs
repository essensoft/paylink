using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsCooperationRegionQrcodeApplyResponse.
    /// </summary>
    public class AlipayInsCooperationRegionQrcodeApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 快捷投保产品二维码图片链接URL
        /// </summary>
        [JsonProperty("code_url")]
        [XmlElement("code_url")]
        public string CodeUrl { get; set; }
    }
}
