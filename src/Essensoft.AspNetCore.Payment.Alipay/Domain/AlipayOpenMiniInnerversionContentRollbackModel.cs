using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionContentRollbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionContentRollbackModel : AlipayObject
    {
        /// <summary>
        /// 业务场景来源
        /// </summary>
        [JsonProperty("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序当前上架版本号
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序所属主体
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }
    }
}
