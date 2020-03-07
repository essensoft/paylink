using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotProfileSnBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotProfileSnBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 申请单id
        /// </summary>
        [JsonPropertyName("apply_id")]
        public long ApplyId { get; set; }
    }
}
