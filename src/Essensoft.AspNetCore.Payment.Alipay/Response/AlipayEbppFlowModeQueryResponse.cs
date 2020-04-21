using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppFlowModeQueryResponse.
    /// </summary>
    public class AlipayEbppFlowModeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 抽奖活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_msg")]
        public string ExtMsg { get; set; }

        /// <summary>
        /// 业务方上送手机号
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 流量产品编码
        /// </summary>
        [JsonPropertyName("product_id")]
        public string ProductId { get; set; }
    }
}
