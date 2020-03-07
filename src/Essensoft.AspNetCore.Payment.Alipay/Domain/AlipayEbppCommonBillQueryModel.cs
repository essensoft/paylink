using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppCommonBillQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppCommonBillQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝账单流水号（取自创建账单接口返回的alipay_order_no字段）
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }
    }
}
