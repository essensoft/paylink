using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniTinyappExistQueryResponse.
    /// </summary>
    public class AlipayOpenMiniTinyappExistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否是小程序开发者
        /// </summary>
        [JsonProperty("exist_mini")]
        [XmlElement("exist_mini")]
        public string ExistMini { get; set; }
    }
}
