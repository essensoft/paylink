using System.Text.Json.Serialization;

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
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 欺诈关注清单是否命中，yes标识命中，no标识未命中
        /// </summary>
        [JsonPropertyName("hit")]
        public string Hit { get; set; }

        /// <summary>
        /// 欺诈关注清单的RiskCode列表，对应的描述见产品文档
        /// </summary>
        [JsonPropertyName("risk_code")]
        public string RiskCode { get; set; }

        /// <summary>
        /// 用户唯一请求id
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }
    }
}
