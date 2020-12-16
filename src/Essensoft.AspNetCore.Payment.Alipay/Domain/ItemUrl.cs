using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemUrl Data Structure.
    /// </summary>
    public class ItemUrl : AlipayObject
    {
        /// <summary>
        /// 地址类型；可选值: SC_MINI_APP(支付宝小程序)
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 商品详情地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
