using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniVersionUploadModel : AlipayObject
    {
        /// <summary>
        /// 小程序版本号，版本号必须满足 x.y.z, 且均为数字
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端参数
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 模板的配置参数
        /// </summary>
        [JsonProperty("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板版本号，版本号必须满足 x.y.z, 且均为数字
        /// </summary>
        [JsonProperty("template_version")]
        public string TemplateVersion { get; set; }
    }
}
