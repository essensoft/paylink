using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceInfoApplyidQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceInfoApplyidQueryModel : AlipayObject
    {
        /// <summary>
        /// 申请开票时支付宝返回的申请id，具有全局唯一性。
        /// </summary>
        [JsonPropertyName("apply_id")]
        public string ApplyId { get; set; }
    }
}
