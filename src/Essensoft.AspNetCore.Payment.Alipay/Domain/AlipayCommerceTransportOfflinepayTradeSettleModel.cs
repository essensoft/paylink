using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayTradeSettleModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportOfflinepayTradeSettleModel : AlipayObject
    {
        /// <summary>
        /// 脱机交易列表
        /// </summary>
        [JsonPropertyName("trade_list")]
        public List<AlipayOfflineTrade> TradeList { get; set; }
    }
}
