using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionPreviewUploadModel Data Structure.
    /// </summary>
    [Serializable]
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
        /// 构建参数-IDE 构建好的plugin包地址，小程序插件的有两个构建产物client包和plugin包，该场景下client包地址通过build_pkg_url传递，plugin包地址通过本参数传递
        /// </summary>
        [JsonProperty("build_plugin_url")]
        public string BuildPluginUrl { get; set; }

        /// <summary>
        /// 一个端的标识，用于区分不同的客户端，每接入一个客户端，都需要向小程序应用中心申请bundelId入驻
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 业务扩展属性
        /// </summary>
        [JsonProperty("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 上传调试版的接入租户类型。
        /// </summary>
        [JsonProperty("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序主入口
        /// </summary>
        [JsonProperty("main_url")]
        public string MainUrl { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序代码中引用的插件列表，包含插件id和插件版本信息
        /// </summary>
        [JsonProperty("plugin_refs")]
        public List<MiniAppPluginReference> PluginRefs { get; set; }

        /// <summary>
        /// 预览类型，目前分为“DEBUG(调试版)、TRIAL(试用版)”
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }
    }
}
