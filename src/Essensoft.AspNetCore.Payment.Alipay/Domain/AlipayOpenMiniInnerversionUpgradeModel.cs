using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionUpgradeModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerversionUpgradeModel : AlipayObject
    {
        /// <summary>
        /// 来源类型，新接入方需要向支付宝申请专用来源，否则不予接入。
        /// </summary>
        [JsonPropertyName("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 端ID，多端场景下区分不同端
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序ID，特殊场景专用，普通业务方无需关注该参数。
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 用于升级的模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 用于升级的模板版本号，版本号必须满足 x.y.z, 且均为数字
        /// </summary>
        [JsonPropertyName("template_version")]
        public string TemplateVersion { get; set; }
    }
}
