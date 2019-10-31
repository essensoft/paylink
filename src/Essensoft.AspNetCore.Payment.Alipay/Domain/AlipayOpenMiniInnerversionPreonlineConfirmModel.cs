using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionPreonlineConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionPreonlineConfirmModel : AlipayObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端参数
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序Id
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
