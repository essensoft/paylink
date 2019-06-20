using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StockHolderVO Data Structure.
    /// </summary>
    [Serializable]
    public class StockHolderVO : AlipayObject
    {
        /// <summary>
        /// 出资日期
        /// </summary>
        [JsonProperty("invest_date")]
        public string InvestDate { get; set; }

        /// <summary>
        /// 出资比例(%)
        /// </summary>
        [JsonProperty("invest_rate")]
        public string InvestRate { get; set; }

        /// <summary>
        /// 股东名称
        /// </summary>
        [JsonProperty("org_holder_name")]
        public string OrgHolderName { get; set; }

        /// <summary>
        /// 股东类型
        /// </summary>
        [JsonProperty("org_holder_type")]
        public string OrgHolderType { get; set; }

        /// <summary>
        /// 认缴额（万）
        /// </summary>
        [JsonProperty("subscript_amt")]
        public string SubscriptAmt { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonProperty("subscript_amt_curcy")]
        public string SubscriptAmtCurcy { get; set; }
    }
}
