using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeUserOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeUserOrderSyncModel : AlipayObject
    {
        /// <summary>
        /// 买家的支付宝用户id
        /// </summary>
        [JsonProperty("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 订单待同步信息，不能为空，json格式字符串，自定义key需要提前与接口owner进行沟通确认
        /// </summary>
        [JsonProperty("order_info")]
        public string OrderInfo { get; set; }

        /// <summary>
        /// 商家订单号，需要保证在商家侧唯一
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 外部请求幂等号，代表了一次请求，作为业务幂等性控制
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 卖家的支付宝id
        /// </summary>
        [JsonProperty("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 商家业务子订单号，一个子订单号只能属于一个主订单号(out_order_no)
        /// </summary>
        [JsonProperty("sub_out_order_no")]
        public string SubOutOrderNo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
