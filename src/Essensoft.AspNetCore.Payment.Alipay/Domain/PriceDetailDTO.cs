using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PriceDetailDTO Data Structure.
    /// </summary>
    public class PriceDetailDTO : AlipayObject
    {
        /// <summary>
        /// 奖品领取跳转链接
        /// </summary>
        [JsonPropertyName("price_click_url")]
        public string PriceClickUrl { get; set; }

        /// <summary>
        /// 权益优惠信息
        /// </summary>
        [JsonPropertyName("price_title")]
        public string PriceTitle { get; set; }
    }
}
