using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicXwbtestabcdBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicXwbtestabcdBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 1111112141414
        /// </summary>
        [JsonPropertyName("s")]
        public string S { get; set; }
    }
}
