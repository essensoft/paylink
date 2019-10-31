using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionLastQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionLastQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务来源场景
        /// </summary>
        [JsonProperty("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 端信息
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序主体
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }
    }
}
