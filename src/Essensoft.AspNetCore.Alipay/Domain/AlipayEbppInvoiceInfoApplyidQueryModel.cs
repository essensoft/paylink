using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceInfoApplyidQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceInfoApplyidQueryModel : AlipayObject
    {
        /// <summary>
        /// 申请开票时支付宝返回的申请id，具有全局唯一性。
        /// </summary>
        [JsonProperty("apply_id")]
        public string ApplyId { get; set; }
    }
}
