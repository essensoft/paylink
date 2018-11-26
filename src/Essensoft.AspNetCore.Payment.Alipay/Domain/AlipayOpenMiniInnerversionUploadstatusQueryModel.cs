using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionUploadstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionUploadstatusQueryModel : AlipayObject
    {
        /// <summary>
        /// 包管理ID，用于查询打包状态
        /// </summary>
        [JsonProperty("build_package_id")]
        [XmlElement("build_package_id")]
        public string BuildPackageId { get; set; }

        /// <summary>
        /// 小程序版本
        /// </summary>
        [JsonProperty("build_version")]
        [XmlElement("build_version")]
        public string BuildVersion { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonProperty("mini_app_id")]
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
