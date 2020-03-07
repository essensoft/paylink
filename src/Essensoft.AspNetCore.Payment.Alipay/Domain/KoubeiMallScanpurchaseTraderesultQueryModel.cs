using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMallScanpurchaseTraderesultQueryModel Data Structure.
    /// </summary>
    public class KoubeiMallScanpurchaseTraderesultQueryModel : AlipayObject
    {
        /// <summary>
        /// 说明渠道，口碑app为 APP,  口碑tab 为TAB. 默认是TAB
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 买家用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
