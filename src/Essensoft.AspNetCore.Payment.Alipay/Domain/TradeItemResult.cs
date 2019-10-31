using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TradeItemResult Data Structure.
    /// </summary>
    [Serializable]
    public class TradeItemResult : AlipayObject
    {
        /// <summary>
        /// 支付宝订单号。对账使用，不脱敏
        /// </summary>
        [JsonProperty("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 交易创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 交易支付时间
        /// </summary>
        [JsonProperty("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 交易退款时间
        /// </summary>
        [JsonProperty("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 商品备注信息
        /// </summary>
        [JsonProperty("goods_memo")]
        public string GoodsMemo { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("goods_title")]
        public string GoodsTitle { get; set; }

        /// <summary>
        /// 商户订单号，创建支付宝交易时传入的信息。对账使用，不脱敏
        /// </summary>
        [JsonProperty("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 商家优惠金额
        /// </summary>
        [JsonProperty("net_mdiscount")]
        public string NetMdiscount { get; set; }

        /// <summary>
        /// 对方账户
        /// </summary>
        [JsonProperty("other_account")]
        public string OtherAccount { get; set; }

        /// <summary>
        /// 订单退款金额
        /// </summary>
        [JsonProperty("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 服务费金额
        /// </summary>
        [JsonProperty("service_fee")]
        public string ServiceFee { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonProperty("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 门店编号
        /// </summary>
        [JsonProperty("store_no")]
        public string StoreNo { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 订单状态(待付款,成功,关闭,待发货,待确认收货,已预付,进行中)
        /// </summary>
        [JsonProperty("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 业务类型，帮助商户作为对账参考
        /// </summary>
        [JsonProperty("trade_type")]
        public string TradeType { get; set; }
    }
}
