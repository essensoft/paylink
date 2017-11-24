using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionBillQueryModel Data Structure.
    /// </summary>
    public class KoubeiAdvertCommissionBillQueryModel : AlipayObject
    {
        /// <summary>
        /// 账期(格式为yyyyMM)
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// 账单类型  deal-交易账单  settle-结算账单
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
