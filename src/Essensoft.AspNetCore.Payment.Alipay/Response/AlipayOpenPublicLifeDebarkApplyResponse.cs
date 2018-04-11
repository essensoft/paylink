using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeDebarkApplyResponse.
    /// </summary>
    public class AlipayOpenPublicLifeDebarkApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 下架成功后返回的提示
        /// </summary>
        [JsonProperty("result")]
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
