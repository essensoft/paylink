using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeSettleConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSettleConfirmModel : AlipayObject
    {
        /// <summary>
        /// 确认结算请求流水号，开发者自行生成并保证唯一性，作为业务幂等性控制
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 描述结算信息，json格式，详见结算参数说明
        /// </summary>
        [JsonProperty("settle_info")]
        public SettleInfo SettleInfo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
