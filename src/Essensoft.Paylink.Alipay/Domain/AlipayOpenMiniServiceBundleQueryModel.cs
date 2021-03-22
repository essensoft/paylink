using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniServiceBundleQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniServiceBundleQueryModel : AlipayObject
    {
        /// <summary>
        /// 多端投放客户端标识
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页容量
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }
    }
}
