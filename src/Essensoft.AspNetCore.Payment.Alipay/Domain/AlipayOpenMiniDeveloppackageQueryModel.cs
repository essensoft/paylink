using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniDeveloppackageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniDeveloppackageQueryModel : AlipayObject
    {
        /// <summary>
        /// 一个端的标识，用于区分不同的客户端，每接入一个客户端，都需要向小程序应用中心申请bundelId入驻
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 部署版本号，一个应用、租户、端在应用中心唯一的一条发布记录版本号。
        /// </summary>
        [JsonProperty("deploy_version")]
        public string DeployVersion { get; set; }

        /// <summary>
        /// 开发者标识的版本，这个版本号和deploy_version是二选一。
        /// </summary>
        [JsonProperty("developer_version")]
        public string DeveloperVersion { get; set; }

        /// <summary>
        /// 租户类型，由应用中心分配
        /// </summary>
        [JsonProperty("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 拉包协议版本
        /// </summary>
        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// 类型，目前分为“DEBUG(调试版)、TRIAL(试用版)”
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
