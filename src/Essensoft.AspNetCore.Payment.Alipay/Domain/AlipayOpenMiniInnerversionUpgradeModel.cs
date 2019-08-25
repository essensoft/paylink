using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionUpgradeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionUpgradeModel : AlipayObject
    {
        /// <summary>
        /// 来源类型，新接入方需要向支付宝申请专用来源，否则不予接入。
        /// </summary>
        [JsonProperty("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 端ID，多端场景下区分不同端
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 需要升级的实例小程序appId，仅用于一方链路，其他无用
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 用于升级的模板id
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 用于升级的模板版本号，版本号必须满足 x.y.z, 且均为数字
        /// </summary>
        [JsonProperty("template_version")]
        public string TemplateVersion { get; set; }
    }
}
