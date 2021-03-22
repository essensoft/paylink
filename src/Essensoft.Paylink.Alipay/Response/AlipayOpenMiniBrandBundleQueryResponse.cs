using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniBrandBundleQueryResponse.
    /// </summary>
    public class AlipayOpenMiniBrandBundleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否经过品牌认证
        /// </summary>
        [JsonPropertyName("brand_certified")]
        public bool BrandCertified { get; set; }

        /// <summary>
        /// 小程序品牌词
        /// </summary>
        [JsonPropertyName("brand_word")]
        public string BrandWord { get; set; }
    }
}
