using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SpecifiedChannelParam Data Structure.
    /// </summary>
    public class SpecifiedChannelParam : AlipayObject
    {
        /// <summary>
        /// 指定渠道签约号
        /// </summary>
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产编码
        /// </summary>
        [JsonPropertyName("asset_type_code")]
        public string AssetTypeCode { get; set; }

        /// <summary>
        /// 银行卡类型，只有在资产类型为BANKCARD时才有效。如果为空，则标识不限制卡类型。卡类型在有值时，仅支持 两类传参：DD-贷记卡（储蓄卡），CC-信用卡。
        /// </summary>
        [JsonPropertyName("bank_card_type")]
        public string BankCardType { get; set; }

        /// <summary>
        /// 机构编码
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 资产类型，用以标识资产大类。BANKCARD - 银行卡
        /// </summary>
        [JsonPropertyName("pay_tool_type")]
        public string PayToolType { get; set; }
    }
}
