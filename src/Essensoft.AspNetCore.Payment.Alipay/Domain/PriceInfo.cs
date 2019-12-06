using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PriceInfo Data Structure.
    /// </summary>
    public class PriceInfo : AlipayObject
    {
        /// <summary>
        /// 商品价格维度信息
        /// </summary>
        [JsonPropertyName("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// 价格，单位为元
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }
    }
}
