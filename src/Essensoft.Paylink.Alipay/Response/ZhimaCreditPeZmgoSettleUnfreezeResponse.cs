using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoSettleUnfreezeResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoSettleUnfreezeResponse : AlipayResponse
    {
        /// <summary>
        /// 失败原因
        /// </summary>
        [JsonPropertyName("fail_reaseon")]
        public string FailReaseon { get; set; }

        /// <summary>
        /// 是否可以重试
        /// </summary>
        [JsonPropertyName("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 解冻金额字符串
        /// </summary>
        [JsonPropertyName("unfreeze_amount")]
        public string UnfreezeAmount { get; set; }

        /// <summary>
        /// 解冻状态
        /// </summary>
        [JsonPropertyName("unfreeze_status")]
        public string UnfreezeStatus { get; set; }
    }
}
