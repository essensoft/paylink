using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ApInvoiceBillLinkOrderRequest Data Structure.
    /// </summary>
    public class ApInvoiceBillLinkOrderRequest : AlipayObject
    {
        /// <summary>
        /// 开票金额，金额为null或为0均视为未填关联金额
        /// </summary>
        [JsonPropertyName("amt")]
        public MultiCurrencyMoneyOpenApi Amt { get; set; }

        /// <summary>
        /// 日账单选择维度 map
        /// </summary>
        [JsonPropertyName("daily_bill_dimension")]
        public string DailyBillDimension { get; set; }

        /// <summary>
        /// 可开票对账单号
        /// </summary>
        [JsonPropertyName("monthly_bill_no")]
        public string MonthlyBillNo { get; set; }
    }
}
