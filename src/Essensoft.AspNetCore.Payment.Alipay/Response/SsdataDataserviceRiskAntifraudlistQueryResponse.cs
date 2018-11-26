using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// SsdataDataserviceRiskAntifraudlistQueryResponse.
    /// </summary>
    public class SsdataDataserviceRiskAntifraudlistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 蚁盾对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [JsonProperty("biz_no")]
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 欺诈关注清单是否命中，yes标识命中，no标识未命中
        /// </summary>
        [JsonProperty("hit")]
        [XmlElement("hit")]
        public string Hit { get; set; }

        /// <summary>
        /// 欺诈关注清单的RiskCode列表，对应的描述见产品文档
        /// </summary>
        [JsonProperty("risk_code")]
        [XmlElement("risk_code")]
        public string RiskCode { get; set; }

        /// <summary>
        /// 用户唯一请求id
        /// </summary>
        [JsonProperty("unique_id")]
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
