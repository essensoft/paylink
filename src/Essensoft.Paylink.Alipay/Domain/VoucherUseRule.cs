using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// VoucherUseRule Data Structure.
    /// </summary>
    public class VoucherUseRule : AlipayObject
    {
        /// <summary>
        /// 代金券详情
        /// </summary>
        [JsonPropertyName("fix_voucher")]
        public FixVoucher FixVoucher { get; set; }

        /// <summary>
        /// 日期区间内可以使用优惠
        /// </summary>
        [JsonPropertyName("voucher_valid_period")]
        public VoucherValidPeriod VoucherValidPeriod { get; set; }
    }
}
