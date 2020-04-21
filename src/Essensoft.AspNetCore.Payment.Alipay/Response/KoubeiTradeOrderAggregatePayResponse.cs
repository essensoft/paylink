using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiTradeOrderAggregatePayResponse.
    /// </summary>
    public class KoubeiTradeOrderAggregatePayResponse : AlipayResponse
    {
        /// <summary>
        /// 买家ID, 支付成功时才返回
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 付款用户类型； 支付宝(alipay)/微信(weixin)，支付成功时才返回
        /// </summary>
        [JsonPropertyName("buyer_id_type")]
        public string BuyerIdType { get; set; }

        /// <summary>
        /// 用户实付金额，支付成功时才返回
        /// </summary>
        [JsonPropertyName("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 本交易支付时使用的所有优惠券信息
        /// </summary>
        [JsonPropertyName("discount_detail_list")]
        public List<DiscountDetailInfo> DiscountDetailList { get; set; }

        /// <summary>
        /// 支付成功时间
        /// </summary>
        [JsonPropertyName("gmt_payment_time")]
        public string GmtPaymentTime { get; set; }

        /// <summary>
        /// 商家优惠金额
        /// </summary>
        [JsonPropertyName("merchant_discount_amount")]
        public string MerchantDiscountAmount { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// SUCCESS - 支付成功 FAILED - 支付失败 PROCESSING - 处理中 CLOSED - 关单
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 商家请求订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付渠道； 支付宝(alipay)/微信(wechat)
        /// </summary>
        [JsonPropertyName("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 平台优惠金额
        /// </summary>
        [JsonPropertyName("platform_discount_amount")]
        public string PlatformDiscountAmount { get; set; }

        /// <summary>
        /// 实收金额
        /// </summary>
        [JsonPropertyName("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝/微信交易号； 支付成功时才返回
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
