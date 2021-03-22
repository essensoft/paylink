using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MultiBundleAppServiceResult Data Structure.
    /// </summary>
    public class MultiBundleAppServiceResult : AlipayObject
    {
        /// <summary>
        /// 多端服务客户端标识
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 服务地址
        /// </summary>
        [JsonPropertyName("carrier_url")]
        public string CarrierUrl { get; set; }

        /// <summary>
        /// 是否拥有当前端的链接
        /// </summary>
        [JsonPropertyName("has_bundle_url")]
        public bool HasBundleUrl { get; set; }

        /// <summary>
        /// 服务logo
        /// </summary>
        [JsonPropertyName("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 小程序子服务编码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 叮咚买药
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 子服务简要介绍
        /// </summary>
        [JsonPropertyName("simple_desc")]
        public string SimpleDesc { get; set; }
    }
}
