using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.JDPay.Notify
{
    public class JDPayDefrayPayNotifyResponse : JDPayNotifyResponse
    {
        /// <summary>
        /// 提交者会员号
        /// </summary>
        [XmlElement("customer_no")]
        public string CustomerNo { get; set; }

        /// <summary>
        /// 商户账户号
        /// </summary>
        [XmlElement("merchant_no")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 签名方式
        /// </summary>
        [XmlElement("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名数据
        /// </summary>
        [XmlElement("sign_data")]
        public string SignData { get; set; }

        /// <summary>
        /// 商户订单流水号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 业务订单流水号
        /// </summary>
        [XmlElement("biz_trade_no")]
        public string BizTradeNo { get; set; }

        /// <summary>
        /// 外部交易日
        /// </summary>
        [XmlElement("out_trade_date")]
        public string OutTradeDate { get; set; }

        /// <summary>
        /// 交易类别
        /// </summary>
        [XmlElement("trade_class")]
        public string TradeClass { get; set; }

        /// <summary>
        /// 订单摘要
        /// </summary>
        [XmlElement("trade_subject")]
        public string TradeSubject { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 卖方信息
        /// </summary>
        [XmlElement("seller_info")]
        public string SellerInfo { get; set; }

        /// <summary>
        /// 买方信息
        /// </summary>
        [XmlElement("buyer_info")]
        public string BuyerInfo { get; set; }

        /// <summary>
        /// 订单交易金额
        /// </summary>
        [XmlElement("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 订单交易币种
        /// </summary>
        [XmlElement("trade_currency")]
        public string TradeCurrency { get; set; }

        /// <summary>
        /// 已退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 商户售卖的商品分类码
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 已确认金额
        /// </summary>
        [XmlElement("confirm_amount")]
        public string ConfirmAmount { get; set; }

        /// <summary>
        /// 交易响应码
        /// </summary>
        [XmlElement("trade_respcode")]
        public string TradeRespcode { get; set; }

        /// <summary>
        /// 交易响应描述
        /// </summary>
        [XmlElement("trade_respmsg")]
        public string TradeRespmsg { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 支付完成日
        /// </summary>
        [XmlElement("trade_pay_date")]
        public string TradePayDate { get; set; }

        /// <summary>
        /// 支付完时间
        /// </summary>
        [XmlElement("trade_pay_time")]
        public string TradePayTime { get; set; }

        /// <summary>
        /// 支付工具
        /// </summary>
        [XmlElement("pay_tool")]
        public string PayTool { get; set; }

        /// <summary>
        /// 支付银行
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 支付卡种
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 交易完成日
        /// </summary>
        [XmlElement("trade_finish_date")]
        public string TradeFinishDate { get; set; }

        /// <summary>
        /// 交易完时间
        /// </summary>
        [XmlElement("trade_finish_time")]
        public string TradeFinishTime { get; set; }

        /// <summary>
        /// 订单返回信息
        /// </summary>
        [XmlElement("return_params")]
        public string ReturnParams { get; set; }
    }
}
