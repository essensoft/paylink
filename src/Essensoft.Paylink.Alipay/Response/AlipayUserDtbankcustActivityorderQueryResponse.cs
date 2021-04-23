using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserDtbankcustActivityorderQueryResponse.
    /// </summary>
    public class AlipayUserDtbankcustActivityorderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 数字分行活动唯一id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动流水单据唯一id
        /// </summary>
        [JsonPropertyName("activity_order_id")]
        public string ActivityOrderId { get; set; }

        /// <summary>
        /// 外部唯一业务幂等号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 流水状态 INIT("INIT", "初始化"),  SUCCESS("SUCCESS", "成功"), FAILED("FAILED", "失败"), PENDING("PENDING", "挂起"),
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
