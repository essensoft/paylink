using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMallScanpurchaseTraderesultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMallScanpurchaseTraderesultQueryModel : AlipayObject
    {
        /// <summary>
        /// 说明渠道，口碑app为 APP,  口碑tab 为TAB. 默认是TAB
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 买家用户id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
