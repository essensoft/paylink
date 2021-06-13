using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// VoucherUseRuleModify Data Structure.
    /// </summary>
    public class VoucherUseRuleModify : AlipayObject
    {
        /// <summary>
        /// 日期区间内可以使用优惠
        /// </summary>
        [JsonPropertyName("voucher_valid_period")]
        public VoucherValidPeriodModify VoucherValidPeriod { get; set; }
    }
}
