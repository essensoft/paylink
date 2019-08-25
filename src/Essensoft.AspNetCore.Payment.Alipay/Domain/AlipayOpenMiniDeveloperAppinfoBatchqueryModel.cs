using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniDeveloperAppinfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniDeveloperAppinfoBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 客户端标识
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }
    }
}
