using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiTradeItemorderQueryResponse.
    /// </summary>
    public class KoubeiTradeItemorderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业务产品
        /// </summary>
        [JsonPropertyName("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 买家支付宝账户
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 卖家实收金额，单笔订单中给打款给卖家的金额
        /// </summary>
        [JsonPropertyName("deliver_seller_real_amount")]
        public string DeliverSellerRealAmount { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 订单修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 支付成功时间
        /// </summary>
        [JsonPropertyName("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [JsonPropertyName("item_order_vo")]
        public List<ItemOrderVO> ItemOrderVo { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户签约支付宝账号
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 用户实付金额
        /// </summary>
        [JsonPropertyName("real_pay_amount")]
        public string RealPayAmount { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 订单状态, INIT（初始状态）,WAIT_PAY (待支付)，PAID（已支付），SUCCESS（订单成功-已打款给商户），FINISH（订单完成-全额退款）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单金额
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
