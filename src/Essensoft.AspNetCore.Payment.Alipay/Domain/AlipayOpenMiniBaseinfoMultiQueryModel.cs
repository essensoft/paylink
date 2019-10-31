using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniBaseinfoMultiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniBaseinfoMultiQueryModel : AlipayObject
    {
        /// <summary>
        /// 应用端信息
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
