using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeOrderPayModel Data Structure.
    /// </summary>
    public class AlipayTradeOrderPayModel : AlipayObject
    {
        /// <summary>
        /// 垫资支付模式。支付时需要垫资的场景才传入。具体传参需与支付宝约定。 CREDIT_FULFILLMENT_ZM 表示先用后付产品履约动作支持芝麻垫资。
        /// </summary>
        [JsonPropertyName("advance_payment_type")]
        public string AdvancePaymentType { get; set; }

        /// <summary>
        /// 买家的支付宝用户id    注：  1.用于校验与已存交易中的买家是否相等
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付明细    目前支持的支付渠道为：  - offline_pos：本次买家使用的是pos刷卡支付    注：  各支付工具金额总和=订单总金额
        /// </summary>
        [JsonPropertyName("buyer_pay_detail")]
        public List<BuyerPayDetail> BuyerPayDetail { get; set; }

        /// <summary>
        /// 本次履约支付金额，单位为元，精确到小数点后两位。履约支付场景才需要传入。
        /// </summary>
        [JsonPropertyName("fulfillment_amount")]
        public string FulfillmentAmount { get; set; }

        /// <summary>
        /// 是否异步支付，传入true时，表明本次期望走异步支付，会先将支付请求受理下来，再异步推进。商户可以通过交易的异步通知或者轮询交易的状态来确定最终的交易结果
        /// </summary>
        [JsonPropertyName("is_async_pay")]
        public bool IsAsyncPay { get; set; }

        /// <summary>
        /// 订单支付模式。特殊支付场景才需要传入。具体传参需与支付宝约定。 CREDIT_FULFILLMENT_ZM表示基于芝麻授信的履约支付模式，比如芝麻先用后付产品。
        /// </summary>
        [JsonPropertyName("order_pay_mode")]
        public string OrderPayMode { get; set; }

        /// <summary>
        /// 商户请求号，标识一次请求的唯一id，用于幂等控制。部分履约支付场景下必传。
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]    注：  1.用于校验与已存交易中的金额是否相等
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
