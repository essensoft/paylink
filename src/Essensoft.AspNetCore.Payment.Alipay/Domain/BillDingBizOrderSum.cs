using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BillDingBizOrderSum Data Structure.
    /// </summary>
    public class BillDingBizOrderSum : AlipayObject
    {
        /// <summary>
        /// 日期展示, 月份2018-07,日期2018-07-10
        /// </summary>
        [JsonPropertyName("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 支出金额
        /// </summary>
        [JsonPropertyName("expenses")]
        public string Expenses { get; set; }

        /// <summary>
        /// 收入金额
        /// </summary>
        [JsonPropertyName("income")]
        public string Income { get; set; }
    }
}
