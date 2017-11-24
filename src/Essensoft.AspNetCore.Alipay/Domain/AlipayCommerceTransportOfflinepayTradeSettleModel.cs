using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayTradeSettleModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportOfflinepayTradeSettleModel : AlipayObject
    {
        /// <summary>
        /// 脱机交易列表
        /// </summary>
        [JsonProperty("trade_list")]
        public List<AlipayOfflineTrade> TradeList { get; set; }
    }
}
