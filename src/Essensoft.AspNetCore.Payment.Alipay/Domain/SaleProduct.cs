using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SaleProduct Data Structure.
    /// </summary>
    public class SaleProduct : AlipayObject
    {
        /// <summary>
        /// 宝贝来源 例如：TAOBAO ALIPAY
        /// </summary>
        [JsonPropertyName("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 销售产品DB ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 面额
        /// </summary>
        [JsonPropertyName("market_price")]
        public string MarketPrice { get; set; }

        /// <summary>
        /// 充值产品提供商
        /// </summary>
        [JsonPropertyName("product_provider")]
        public ProductProvider ProductProvider { get; set; }

        /// <summary>
        /// 销售价格
        /// </summary>
        [JsonPropertyName("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 产品状态, 0为不可用，1为可用
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
