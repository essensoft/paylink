using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;
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
        [JsonProperty("biz_product")]
        [XmlElement("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 买家支付宝账户
        /// </summary>
        [JsonProperty("buyer_id")]
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 卖家实收金额，单笔订单中给打款给卖家的金额
        /// </summary>
        [JsonProperty("deliver_seller_real_amount")]
        [XmlElement("deliver_seller_real_amount")]
        public string DeliverSellerRealAmount { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [JsonProperty("discount_amount")]
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 订单修改时间
        /// </summary>
        [JsonProperty("gmt_modified")]
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 支付成功时间
        /// </summary>
        [JsonProperty("gmt_payment")]
        [XmlElement("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [JsonProperty("item_order_vo")]
        [XmlArray("item_order_vo")]
        [XmlArrayItem("item_order_v_o")]
        public List<ItemOrderVO> ItemOrderVo { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonProperty("order_no")]
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("out_order_no")]
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户签约支付宝账号
        /// </summary>
        [JsonProperty("partner_id")]
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 用户实付金额
        /// </summary>
        [JsonProperty("real_pay_amount")]
        [XmlElement("real_pay_amount")]
        public string RealPayAmount { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        [JsonProperty("seller_id")]
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 订单状态, INIT（初始状态）,WAIT_PAY (待支付)，PAID（已支付），SUCCESS（订单成功-已打款给商户），FINISH（订单完成-全额退款）
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonProperty("total_amount")]
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
