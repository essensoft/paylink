using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniDeveloperAppinfoBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniDeveloperAppinfoBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 客户端标识
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }
    }
}
