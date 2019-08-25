using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TradePrecreateConfirmOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TradePrecreateConfirmOrderInfo : AlipayObject
    {
        /// <summary>
        /// 对交易或商品的描述
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// 支付超时的绝对时间
        /// </summary>
        [JsonProperty("pay_expire_time")]
        public string PayExpireTime { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }
    }
}
