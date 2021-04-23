using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppServiceQueryResponse.
    /// </summary>
    public class AlipayOpenAppServiceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 驳回理由
        /// </summary>
        [JsonPropertyName("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务描述xml格式
        /// </summary>
        [JsonPropertyName("service_xml")]
        public string ServiceXml { get; set; }

        /// <summary>
        /// 服务状态，EDITING(编辑中)/AUDITING(审核中)/AUDIT_REJECT(审核驳回)/PROMOTION(可推广)/STOP_PROMOTION(停止推广)/INVALID(失效)/PUNISHED(处罚)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
