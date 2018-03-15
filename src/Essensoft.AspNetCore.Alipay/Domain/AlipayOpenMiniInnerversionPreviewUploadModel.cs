using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionPreviewUploadModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerversionPreviewUploadModel : AlipayObject
    {
        /// <summary>
        /// 构建参数- JSAPI 权限文件, JSON 字符串
        /// </summary>
        [JsonProperty("build_js_permission")]
        public string BuildJsPermission { get; set; }

        /// <summary>
        /// 构建参数-IDE 构建好的包地址
        /// </summary>
        [JsonProperty("build_pkg_url")]
        public string BuildPkgUrl { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
