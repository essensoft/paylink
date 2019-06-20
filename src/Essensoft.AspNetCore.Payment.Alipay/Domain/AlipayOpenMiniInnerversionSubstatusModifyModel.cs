using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionSubstatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionSubstatusModifyModel : AlipayObject
    {
        /// <summary>
        /// 小程序开发版本
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端标识 淘宝：com.taobao.app 支付宝：com.alipay.alipaywallet
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 租户编码
        /// </summary>
        [JsonProperty("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 子状态
        /// </summary>
        [JsonProperty("sub_status")]
        public string SubStatus { get; set; }
    }
}
