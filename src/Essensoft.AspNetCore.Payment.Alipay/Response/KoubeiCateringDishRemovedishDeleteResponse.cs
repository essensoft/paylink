using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishRemovedishDeleteResponse.
    /// </summary>
    public class KoubeiCateringDishRemovedishDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 失败是否需要重试，true：需要重试；false：不需要重试。
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }
    }
}
