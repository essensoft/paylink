using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppServiceMiniappnearbyQueryResponse.
    /// </summary>
    public class AlipayOpenAppServiceMiniappnearbyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 服务载体编码
        /// </summary>
        [JsonPropertyName("carrier_code")]
        public string CarrierCode { get; set; }

        /// <summary>
        /// 载体url
        /// </summary>
        [JsonPropertyName("carrier_url")]
        public string CarrierUrl { get; set; }

        /// <summary>
        /// 服务详述
        /// </summary>
        [JsonPropertyName("detail_desc")]
        public string DetailDesc { get; set; }

        /// <summary>
        /// 前台类目id
        /// </summary>
        [JsonPropertyName("forward_catalog_id")]
        public string ForwardCatalogId { get; set; }

        /// <summary>
        /// 服务关键词
        /// </summary>
        [JsonPropertyName("key_word_list")]
        public string KeyWordList { get; set; }

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

        /// <summary>
        /// 服务简述
        /// </summary>
        [JsonPropertyName("simple_desc")]
        public string SimpleDesc { get; set; }
    }
}
