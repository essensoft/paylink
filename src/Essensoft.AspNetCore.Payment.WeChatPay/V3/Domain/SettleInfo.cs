using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 结算信息
    /// </summary>    
    public class SettleInfo : WeChatPayObject
    {
        /// <summary>
        /// 是否指定分账
        /// 是否指定分账，枚举值
        /// true：是
        /// false：否
        /// 示例值：true
        /// </summary>
        [JsonPropertyName("profit_sharing")]
        public bool ProfitSharing { get; set; }

        /// <summary>
        /// 补差金额	
        /// SettleInfo.profit_sharing为true时，该金额才生效。
        /// 示例值：10
        /// </summary>
        [JsonPropertyName("subsidy_amount")]
        public string SubsidyAmount { get; set; }
    }
}
