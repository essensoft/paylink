using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoCreateModel : AlipayObject
    {
        /// <summary>
        /// 小程序应用名称
        /// </summary>
        [JsonProperty("app_alias_name")]
        public string AppAliasName { get; set; }

        /// <summary>
        /// 小程序应用描述，20-200个字
        /// </summary>
        [JsonProperty("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序logo图标，建议上传像素为180*180
        /// </summary>
        [JsonProperty("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 小程序应用简介，一句话描述小程序功能
        /// </summary>
        [JsonProperty("app_slogan")]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 多端类型
        /// </summary>
        [JsonProperty("client_type")]
        public string ClientType { get; set; }

        /// <summary>
        /// 小程序管理员虚拟 ID
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }
    }
}
