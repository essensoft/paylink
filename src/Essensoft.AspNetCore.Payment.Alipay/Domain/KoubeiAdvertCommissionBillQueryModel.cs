using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionBillQueryModel Data Structure.
    /// </summary>
    public class KoubeiAdvertCommissionBillQueryModel : AlipayObject
    {
        /// <summary>
        /// 账期(格式为yyyyMM)
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// 账单类型  deal-交易账单  settle-结算账单
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
