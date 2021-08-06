using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BoxExclusiveServiceInfo Data Structure.
    /// </summary>
    public class BoxExclusiveServiceInfo : AlipayObject
    {
        /// <summary>
        /// appid
        /// </summary>
        [JsonPropertyName("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 不可用类目id
        /// </summary>
        [JsonPropertyName("catalog_id")]
        public string CatalogId { get; set; }

        /// <summary>
        /// 不可用类目名称
        /// </summary>
        [JsonPropertyName("catalog_name")]
        public string CatalogName { get; set; }

        /// <summary>
        /// 服务规格编码（小程序/生活号）
        /// </summary>
        [JsonPropertyName("sepc_code")]
        public string SepcCode { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务logo
        /// </summary>
        [JsonPropertyName("service_logo")]
        public string ServiceLogo { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }
    }
}
