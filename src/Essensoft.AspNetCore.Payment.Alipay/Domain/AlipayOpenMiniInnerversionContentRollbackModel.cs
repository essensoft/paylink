using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionContentRollbackModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerversionContentRollbackModel : AlipayObject
    {
        /// <summary>
        /// 业务场景来源
        /// </summary>
        [JsonPropertyName("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序当前上架版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序ID，仅特殊场景使用，普通业务方无需关注该参数。
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序所属主体
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
