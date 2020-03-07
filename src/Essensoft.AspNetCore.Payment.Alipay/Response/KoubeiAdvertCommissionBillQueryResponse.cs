using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionBillQueryResponse.
    /// </summary>
    public class KoubeiAdvertCommissionBillQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 账期(格式为yyyyMM)
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// 交易账单  只有type=deal才会有值
        /// </summary>
        [JsonPropertyName("deal_bill")]
        public KbAdvertDealBillResponse DealBill { get; set; }

        /// <summary>
        /// 结算账单  只有type=settle才会有值
        /// </summary>
        [JsonPropertyName("settle_bill")]
        public KbAdvertSettleBillResponse SettleBill { get; set; }

        /// <summary>
        /// 账单类型  deal-交易账单  settle-结算账单
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
