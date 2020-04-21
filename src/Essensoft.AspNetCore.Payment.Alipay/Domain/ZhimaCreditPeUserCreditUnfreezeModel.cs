using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeUserCreditUnfreezeModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeUserCreditUnfreezeModel : AlipayObject
    {
        /// <summary>
        /// 解冻额度，单位为元，取值范围[0.01,100000000]，精确到小数点后2位
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 买家的支付宝用户id
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 解冻时扩展信息，子订单扩展信息，json格式字符串
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 接入商家的订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 卖家的支付宝id
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 商户子订单号，一个子订单号只能对应一个主订单号(out_order_no)
        /// </summary>
        [JsonPropertyName("sub_out_order_no")]
        public string SubOutOrderNo { get; set; }

        /// <summary>
        /// 解冻类型(退款解冻/支付解冻)，可选值分别是refund_unfreeze/pay_unfreeze；
        /// </summary>
        [JsonPropertyName("unfreeze_type")]
        public string UnfreezeType { get; set; }
    }
}
