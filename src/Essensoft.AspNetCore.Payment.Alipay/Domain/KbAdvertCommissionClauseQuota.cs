using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertCommissionClauseQuota Data Structure.
    /// </summary>
    public class KbAdvertCommissionClauseQuota : AlipayObject
    {
        /// <summary>
        /// 定额结束范围(精度2位的非负小数)
        /// </summary>
        [JsonPropertyName("quota_amount_end")]
        public string QuotaAmountEnd { get; set; }

        /// <summary>
        /// 定额开始范围(精度2位的非负小数)
        /// </summary>
        [JsonPropertyName("quota_amount_start")]
        public string QuotaAmountStart { get; set; }
    }
}
