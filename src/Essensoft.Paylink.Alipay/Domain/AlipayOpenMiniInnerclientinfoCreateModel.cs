using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerclientinfoCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerclientinfoCreateModel : AlipayObject
    {
        /// <summary>
        /// 端ID，不可重复，接入方需要和小程序平台约定格式
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 端名称
        /// </summary>
        [JsonPropertyName("bundle_name")]
        public string BundleName { get; set; }

        /// <summary>
        /// 端信息缓存前缀，不可重复，接入方需要和小程序平台约定前后缀信息
        /// </summary>
        [JsonPropertyName("bundle_prefix")]
        public string BundlePrefix { get; set; }

        /// <summary>
        /// 租户code，手淘租户:taobao，钉钉租户:dingding；参数不填默认为手淘租户
        /// </summary>
        [JsonPropertyName("inst_code")]
        public string InstCode { get; set; }
    }
}
