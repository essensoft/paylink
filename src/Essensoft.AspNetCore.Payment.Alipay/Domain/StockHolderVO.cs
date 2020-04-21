using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StockHolderVO Data Structure.
    /// </summary>
    public class StockHolderVO : AlipayObject
    {
        /// <summary>
        /// 出资日期
        /// </summary>
        [JsonPropertyName("invest_date")]
        public string InvestDate { get; set; }

        /// <summary>
        /// 出资比例(%)
        /// </summary>
        [JsonPropertyName("invest_rate")]
        public string InvestRate { get; set; }

        /// <summary>
        /// 股东名称
        /// </summary>
        [JsonPropertyName("org_holder_name")]
        public string OrgHolderName { get; set; }

        /// <summary>
        /// 股东类型
        /// </summary>
        [JsonPropertyName("org_holder_type")]
        public string OrgHolderType { get; set; }

        /// <summary>
        /// 认缴额（万）
        /// </summary>
        [JsonPropertyName("subscript_amt")]
        public string SubscriptAmt { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("subscript_amt_curcy")]
        public string SubscriptAmtCurcy { get; set; }
    }
}
