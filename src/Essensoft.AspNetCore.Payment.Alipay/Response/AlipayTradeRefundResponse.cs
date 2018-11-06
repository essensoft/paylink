using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeRefundResponse.
    /// </summary>
    public class AlipayTradeRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 用户的登录id
        /// </summary>
        [JsonProperty("buyer_logon_id")]
        [XmlElement("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [JsonProperty("buyer_user_id")]
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 本次退款是否发生了资金变化
        /// </summary>
        [JsonProperty("fund_change")]
        [XmlElement("fund_change")]
        public string FundChange { get; set; }

        /// <summary>
        /// 退款支付时间
        /// </summary>
        [JsonProperty("gmt_refund_pay")]
        [XmlElement("gmt_refund_pay")]
        public string GmtRefundPay { get; set; }

        /// <summary>
        /// 买家支付宝用户号，该参数已废弃，请不要使用
        /// </summary>
        [JsonProperty("open_id")]
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("out_trade_no")]
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 本次退款金额中买家退款金额
        /// </summary>
        [JsonProperty("present_refund_buyer_amount")]
        [XmlElement("present_refund_buyer_amount")]
        public string PresentRefundBuyerAmount { get; set; }

        /// <summary>
        /// 本次退款金额中平台优惠退款金额
        /// </summary>
        [JsonProperty("present_refund_discount_amount")]
        [XmlElement("present_refund_discount_amount")]
        public string PresentRefundDiscountAmount { get; set; }

        /// <summary>
        /// 本次退款金额中商家优惠退款金额
        /// </summary>
        [JsonProperty("present_refund_mdiscount_amount")]
        [XmlElement("present_refund_mdiscount_amount")]
        public string PresentRefundMdiscountAmount { get; set; }

        /// <summary>
        /// 退款币种信息
        /// </summary>
        [JsonProperty("refund_currency")]
        [XmlElement("refund_currency")]
        public string RefundCurrency { get; set; }

        /// <summary>
        /// 退款使用的资金渠道
        /// </summary>
        [JsonProperty("refund_detail_item_list")]
        [XmlArray("refund_detail_item_list")]
        [XmlArrayItem("trade_fund_bill")]
        public List<TradeFundBill> RefundDetailItemList { get; set; }

        /// <summary>
        /// 退款总金额
        /// </summary>
        [JsonProperty("refund_fee")]
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 退回的前置资产列表
        /// </summary>
        [JsonProperty("refund_preset_paytool_list")]
        [XmlElement("refund_preset_paytool_list")]
        public PresetPayToolInfo RefundPresetPaytoolList { get; set; }

        /// <summary>
        /// 本次商户实际退回金额  注：在签约收单产品时需勾选“返回资金明细”才会返回
        /// </summary>
        [JsonProperty("send_back_fee")]
        [XmlElement("send_back_fee")]
        public string SendBackFee { get; set; }

        /// <summary>
        /// 交易在支付时候的门店名称
        /// </summary>
        [JsonProperty("store_name")]
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 2013112011001004330000121536
        /// </summary>
        [JsonProperty("trade_no")]
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
