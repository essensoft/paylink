using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// VoucherUseRule Data Structure.
    /// </summary>
    public class VoucherUseRule : AlipayObject
    {
        /// <summary>
        /// 兑换券详情  限制: 券类型为兑换券时必传
        /// </summary>
        [JsonPropertyName("exchange_voucher")]
        public ExchangeVoucher ExchangeVoucher { get; set; }

        /// <summary>
        /// 满减券详情  限制: 券类型为满减券时必传
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
