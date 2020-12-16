using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeRepaybillBillinConfirmResponse.
    /// </summary>
    public class AlipayTradeRepaybillBillinConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 账单累计已入账金额,精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 2019091810299100060000003480
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单的状态，INIT：入账；VALID：出账；OVERDUE：逾期；CLEAR：账单结清
        /// </summary>
        [JsonPropertyName("bill_status")]
        public string BillStatus { get; set; }
    }
}
