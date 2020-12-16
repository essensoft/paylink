using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SalePlanInfo Data Structure.
    /// </summary>
    public class SalePlanInfo : AlipayObject
    {
        /// <summary>
        /// 个性化价格描述
        /// </summary>
        [JsonPropertyName("custom_price_desc")]
        public string CustomPriceDesc { get; set; }

        /// <summary>
        /// 主(销售方案id)商品id
        /// </summary>
        [JsonPropertyName("main_ps_id")]
        public string MainPsId { get; set; }

        /// <summary>
        /// 价格描述
        /// </summary>
        [JsonPropertyName("price_desc")]
        public string PriceDesc { get; set; }

        /// <summary>
        /// 特殊价格:STANDARD_PRICE/CUSTOM_PRICE
        /// </summary>
        [JsonPropertyName("price_type")]
        public string PriceType { get; set; }

        /// <summary>
        /// 销售方案或者商品列表
        /// </summary>
        [JsonPropertyName("ps_id")]
        public string PsId { get; set; }
    }
}
