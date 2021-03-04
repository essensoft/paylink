using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 结算信息
    /// </summary>
    public class SettleInfo : WeChatPayObject
    {
        /// <summary>
        /// 是否指定分账
        /// </summary>
        /// <remarks>
        /// true：是
        /// false：否
        /// <para>示例值：true</para>
        /// </remarks>
        [JsonPropertyName("profit_sharing")]
        public bool? ProfitSharing { get; set; }

        /// <summary>
        /// 补差金额
        /// </summary>
        /// <remarks>
        /// SettleInfo.profit_sharing为true时，该金额才生效。
        /// 注意：单笔订单最高补差金额为5000元
        /// <para>示例值：10</para>
        /// </remarks>
        [JsonPropertyName("subsidy_amount")]
        public long? SubsidyAmount { get; set; }
    }
}
