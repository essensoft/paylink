using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionUploadModel : AlipayObject
    {
        /// <summary>
        /// IDE开发打包类型
        /// </summary>
        [JsonProperty("build_app_type")]
        [XmlElement("build_app_type")]
        public string BuildAppType { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("build_extra_info")]
        [XmlElement("build_extra_info")]
        public string BuildExtraInfo { get; set; }

        /// <summary>
        /// js api 权限文件
        /// </summary>
        [JsonProperty("build_js_permission")]
        [XmlElement("build_js_permission")]
        public string BuildJsPermission { get; set; }

        /// <summary>
        /// 主入口
        /// </summary>
        [JsonProperty("build_main_url")]
        [XmlElement("build_main_url")]
        public string BuildMainUrl { get; set; }

        /// <summary>
        /// 源码包MD5
        /// </summary>
        [JsonProperty("build_package_md_5")]
        [XmlElement("build_package_md_5")]
        public string BuildPackageMd5 { get; set; }

        /// <summary>
        /// 包名称
        /// </summary>
        [JsonProperty("build_package_name")]
        [XmlElement("build_package_name")]
        public string BuildPackageName { get; set; }

        /// <summary>
        /// 小程序源码包
        /// </summary>
        [JsonProperty("build_package_stream")]
        [XmlElement("build_package_stream")]
        public string BuildPackageStream { get; set; }

        /// <summary>
        /// 打包平台扩展信息
        /// </summary>
        [JsonProperty("build_qcloud_info")]
        [XmlElement("build_qcloud_info")]
        public string BuildQcloudInfo { get; set; }

        /// <summary>
        /// 源码包地址
        /// </summary>
        [JsonProperty("build_source_pkg_url")]
        [XmlElement("build_source_pkg_url")]
        public string BuildSourcePkgUrl { get; set; }

        /// <summary>
        /// 子入口
        /// </summary>
        [JsonProperty("build_sub_url")]
        [XmlElement("build_sub_url")]
        public string BuildSubUrl { get; set; }

        /// <summary>
        /// 小程序版本
        /// </summary>
        [JsonProperty("build_version")]
        [XmlElement("build_version")]
        public string BuildVersion { get; set; }

        /// <summary>
        /// 多端类型
        /// </summary>
        [JsonProperty("client_type")]
        [XmlElement("client_type")]
        public string ClientType { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonProperty("mini_app_id")]
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
