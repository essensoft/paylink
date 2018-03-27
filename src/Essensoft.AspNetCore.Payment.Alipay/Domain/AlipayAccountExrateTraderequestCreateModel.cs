using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountExrateTraderequestCreateModel Data Structure.
    /// </summary>
    public class AlipayAccountExrateTraderequestCreateModel : AlipayObject
    {
        /// <summary>
        /// 交易请求对象内容
        /// </summary>
        [JsonProperty("trade_request")]
        public TradeRequestVO TradeRequest { get; set; }
    }
}
