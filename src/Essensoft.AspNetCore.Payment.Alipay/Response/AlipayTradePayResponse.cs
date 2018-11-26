using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradePayResponse.
    /// </summary>
    public class AlipayTradePayResponse : AlipayResponse
    {
        /// <summary>
        /// 异步支付模式，先享后付业务会返回该参数，目前有三种值：  ASYNC_DELAY_PAY(异步延时付款);  ASYNC_REALTIME_PAY(异步准实时付款);  SYNC_DIRECT_PAY(同步直接扣款);
        /// </summary>
        [JsonProperty("async_payment_mode")]
        [XmlElement("async_payment_mode")]
        public string AsyncPaymentMode { get; set; }

        /// <summary>
        /// 预授权支付模式，该参数仅在信用预授权支付场景下返回。信用预授权支付：CREDIT_PREAUTH_PAY
        /// </summary>
        [JsonProperty("auth_trade_pay_mode")]
        [XmlElement("auth_trade_pay_mode")]
        public string AuthTradePayMode { get; set; }

        /// <summary>
        /// 商户传入业务信息，具体值要和支付宝约定  将商户传入信息分发给相应系统，应用于安全，营销等参数直传场景  格式为json格式
        /// </summary>
        [JsonProperty("business_params")]
        [XmlElement("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 买家支付宝账号
        /// </summary>
        [JsonProperty("buyer_logon_id")]
        [XmlElement("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 买家付款的金额
        /// </summary>
        [JsonProperty("buyer_pay_amount")]
        [XmlElement("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [JsonProperty("buyer_user_id")]
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 买家用户类型。CORPORATE:企业用户；PRIVATE:个人用户。
        /// </summary>
        [JsonProperty("buyer_user_type")]
        [XmlElement("buyer_user_type")]
        public string BuyerUserType { get; set; }

        /// <summary>
        /// 支付宝卡余额
        /// </summary>
        [JsonProperty("card_balance")]
        [XmlElement("card_balance")]
        public string CardBalance { get; set; }

        /// <summary>
        /// 平台优惠金额
        /// </summary>
        [JsonProperty("discount_amount")]
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 本次交易支付所使用的单品券优惠的商品优惠信息
        /// </summary>
        [JsonProperty("discount_goods_detail")]
        [XmlElement("discount_goods_detail")]
        public string DiscountGoodsDetail { get; set; }

        /// <summary>
        /// 交易支付使用的资金渠道
        /// </summary>
        [JsonProperty("fund_bill_list")]
        [XmlArray("fund_bill_list")]
        [XmlArrayItem("trade_fund_bill")]
        public List<TradeFundBill> FundBillList { get; set; }

        /// <summary>
        /// 交易支付时间
        /// </summary>
        [JsonProperty("gmt_payment")]
        [XmlElement("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 交易中可给用户开具发票的金额
        /// </summary>
        [JsonProperty("invoice_amount")]
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 商家优惠金额
        /// </summary>
        [JsonProperty("mdiscount_amount")]
        [XmlElement("mdiscount_amount")]
        public string MdiscountAmount { get; set; }

        /// <summary>
        /// 买家支付宝用户号,该参数已废弃，请不要使用
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
        /// 支付币种订单金额
        /// </summary>
        [JsonProperty("pay_amount")]
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付币种
        /// </summary>
        [JsonProperty("pay_currency")]
        [XmlElement("pay_currency")]
        public string PayCurrency { get; set; }

        /// <summary>
        /// 使用集分宝付款的金额
        /// </summary>
        [JsonProperty("point_amount")]
        [XmlElement("point_amount")]
        public string PointAmount { get; set; }

        /// <summary>
        /// 实收金额
        /// </summary>
        [JsonProperty("receipt_amount")]
        [XmlElement("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 结算币种订单金额
        /// </summary>
        [JsonProperty("settle_amount")]
        [XmlElement("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 商户指定的结算币种，目前支持英镑：GBP、港币：HKD、美元：USD、新加坡元：SGD、日元：JPY、加拿大元：CAD、澳元：AUD、欧元：EUR、新西兰元：NZD、韩元：KRW、泰铢：THB、瑞士法郎：CHF、瑞典克朗：SEK、丹麦克朗：DKK、挪威克朗：NOK、马来西亚林吉特：MYR、印尼卢比：IDR、菲律宾比索：PHP、毛里求斯卢比：MUR、以色列新谢克尔：ILS、斯里兰卡卢比：LKR、俄罗斯卢布：RUB、阿联酋迪拉姆：AED、捷克克朗：CZK、南非兰特：ZAR、人民币：CNY
        /// </summary>
        [JsonProperty("settle_currency")]
        [XmlElement("settle_currency")]
        public string SettleCurrency { get; set; }

        /// <summary>
        /// 结算币种兑换标价币种汇率
        /// </summary>
        [JsonProperty("settle_trans_rate")]
        [XmlElement("settle_trans_rate")]
        public string SettleTransRate { get; set; }

        /// <summary>
        /// 发生支付交易的商户门店名称
        /// </summary>
        [JsonProperty("store_name")]
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 交易金额
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

        /// <summary>
        /// 标价币种, total_amount对应的币种单位。目前支持英镑：GBP、港币：HKD、美元：USD、新加坡元：SGD、日元：JPY、加拿大元：CAD、澳元：AUD、欧元：EUR、新西兰元：NZD、韩元：KRW、泰铢：THB、瑞士法郎：CHF、瑞典克朗：SEK、丹麦克朗：DKK、挪威克朗：NOK、马来西亚林吉特：MYR、印尼卢比：IDR、菲律宾比索：PHP、毛里求斯卢比：MUR、以色列新谢克尔：ILS、斯里兰卡卢比：LKR、俄罗斯卢布：RUB、阿联酋迪拉姆：AED、捷克克朗：CZK、南非兰特：ZAR、人民币：CNY
        /// </summary>
        [JsonProperty("trans_currency")]
        [XmlElement("trans_currency")]
        public string TransCurrency { get; set; }

        /// <summary>
        /// 标价币种兑换支付币种汇率
        /// </summary>
        [JsonProperty("trans_pay_rate")]
        [XmlElement("trans_pay_rate")]
        public string TransPayRate { get; set; }

        /// <summary>
        /// 本交易支付时使用的所有优惠券信息
        /// </summary>
        [JsonProperty("voucher_detail_list")]
        [XmlArray("voucher_detail_list")]
        [XmlArrayItem("voucher_detail")]
        public List<VoucherDetail> VoucherDetailList { get; set; }
    }
}
