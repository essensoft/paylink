using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionAuditCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniVersionAuditCancelModel : AlipayObject
    {
        /// <summary>
        /// 小程序版本号, 可不选, 默认撤消正在审核中的版本
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端参数，可不选，默认支付宝端(com.alipay.alipaywallet:支付宝端)
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }
    }
}
