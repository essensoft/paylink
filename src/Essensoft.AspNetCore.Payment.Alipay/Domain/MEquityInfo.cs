using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MEquityInfo Data Structure.
    /// </summary>
    public class MEquityInfo : AlipayObject
    {
        /// <summary>
        /// 权益的展示信息，仅当equity_type=VOUCHER时，该值必填，其他类型无需设置
        /// </summary>
        [JsonPropertyName("equity_display_info")]
        public MEquityDisplayInfo EquityDisplayInfo { get; set; }

        /// <summary>
        /// 权益类型，枚举取值：券类型：VOUCHER、立减实时优惠类型：DISCOUNT
        /// </summary>
        [JsonPropertyName("equity_type")]
        public string EquityType { get; set; }

        /// <summary>
        /// 使用规则
        /// </summary>
        [JsonPropertyName("equity_use_rule")]
        public MEquityUseRule EquityUseRule { get; set; }

        /// <summary>
        /// 权益的有效期信息，仅当equity_type=VOUCHER时，该值必填，其他类型无需设置
        /// </summary>
        [JsonPropertyName("equity_valid_info")]
        public MEquityValidInfo EquityValidInfo { get; set; }

        /// <summary>
        /// 权益的价值信息
        /// </summary>
        [JsonPropertyName("equity_worth_info")]
        public MEquityWorthInfo EquityWorthInfo { get; set; }
    }
}
