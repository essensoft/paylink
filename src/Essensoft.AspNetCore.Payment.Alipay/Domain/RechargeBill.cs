using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RechargeBill Data Structure.
    /// </summary>
    [Serializable]
    public class RechargeBill : AlipayObject
    {
        /// <summary>
        /// 用户充值金额，单位为元
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 充值时间：YYYY-MM-DD hh:mm:ss
        /// </summary>
        [JsonProperty("deposit_time")]
        public string DepositTime { get; set; }

        /// <summary>
        /// Transfer：待圈存  Success：圈存成功  Fail：圈存失败
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
