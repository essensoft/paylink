using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayOrderInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayOrderInfoVO : AlipayObject
    {
        /// <summary>
        /// 外部平台订单号，如果传给支付宝收单时带着前缀，此处也需要
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 卖家支付宝账户ID
        /// </summary>
        [JsonProperty("seller_user_id")]
        public string SellerUserId { get; set; }
    }
}
