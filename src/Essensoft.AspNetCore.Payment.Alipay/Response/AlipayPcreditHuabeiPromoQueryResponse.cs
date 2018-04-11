using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPromoQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPromoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 花呗颜值分
        /// </summary>
        [JsonProperty("facescore")]
        [XmlElement("facescore")]
        public string Facescore { get; set; }
    }
}
