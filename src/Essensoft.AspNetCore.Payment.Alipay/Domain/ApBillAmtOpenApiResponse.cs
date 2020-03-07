using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ApBillAmtOpenApiResponse Data Structure.
    /// </summary>
    public class ApBillAmtOpenApiResponse : AlipayObject
    {
        /// <summary>
        /// 账单号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 分摊金额
        /// </summary>
        [JsonPropertyName("share_amt")]
        public MultiCurrencyMoneyOpenApi ShareAmt { get; set; }
    }
}
