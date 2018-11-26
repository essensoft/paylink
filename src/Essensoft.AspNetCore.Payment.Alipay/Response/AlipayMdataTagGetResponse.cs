using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMdataTagGetResponse.
    /// </summary>
    public class AlipayMdataTagGetResponse : AlipayResponse
    {
        /// <summary>
        /// 查询到的标签值, JSON字符串
        /// </summary>
        [JsonProperty("tag_values")]
        [XmlElement("tag_values")]
        public string TagValues { get; set; }
    }
}
