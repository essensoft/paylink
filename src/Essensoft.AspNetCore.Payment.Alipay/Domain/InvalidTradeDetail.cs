using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvalidTradeDetail Data Structure.
    /// </summary>
    public class InvalidTradeDetail : AlipayObject
    {
        /// <summary>
        /// 错误信息，用于描述单条交易数据错误原因
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 商户口碑门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商户门店名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 商户单门店下线下交易数据详细信息
        /// </summary>
        [JsonPropertyName("trade_detail")]
        public IntelligentGuideTradeDetail TradeDetail { get; set; }
    }
}
