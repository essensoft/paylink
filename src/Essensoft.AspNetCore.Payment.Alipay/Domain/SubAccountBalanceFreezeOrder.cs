using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SubAccountBalanceFreezeOrder Data Structure.
    /// </summary>
    public class SubAccountBalanceFreezeOrder : AlipayObject
    {
        /// <summary>
        /// 需要冻结金额，如果可用余额大于冻结金额则冻结
        /// </summary>
        [JsonPropertyName("freeze_amount")]
        public MultiCurrencyMoney FreezeAmount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 上游申请请求单号，source + outBizNo 用于幂等。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 来源，通常为业务系统名，source + outBizNo 用于幂等。
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 子户基本信息，用于子户识别
        /// </summary>
        [JsonPropertyName("sub_account_base_info")]
        public SubAccountBaseInfo SubAccountBaseInfo { get; set; }
    }
}
