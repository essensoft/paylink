using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniVersionDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端参数，可不选，默认支付宝端
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }
    }
}
