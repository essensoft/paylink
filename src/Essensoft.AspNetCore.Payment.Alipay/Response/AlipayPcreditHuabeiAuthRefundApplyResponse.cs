using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthRefundApplyResponse.
    /// </summary>
    public class AlipayPcreditHuabeiAuthRefundApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 授权支付单ID
        /// </summary>
        [JsonPropertyName("auth_opt_id")]
        public string AuthOptId { get; set; }

        /// <summary>
        /// 退款操作错误原因描述
        /// </summary>
        [JsonPropertyName("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 是否可重试
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }
    }
}
