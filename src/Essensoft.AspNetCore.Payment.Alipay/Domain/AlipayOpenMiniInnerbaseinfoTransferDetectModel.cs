using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoTransferDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerbaseinfoTransferDetectModel : AlipayObject
    {
        /// <summary>
        /// 用户信息
        /// </summary>
        [JsonProperty("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 需要迁移校验的小程序ID
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
