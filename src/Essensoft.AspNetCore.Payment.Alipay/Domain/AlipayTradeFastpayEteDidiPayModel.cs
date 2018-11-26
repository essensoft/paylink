using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeFastpayEteDidiPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeFastpayEteDidiPayModel : AlipayObject
    {
        /// <summary>
        /// 对一笔交易的具体描述信息。如果是多种商品，请将商品描述字符串累加传给body。
        /// </summary>
        [JsonProperty("body")]
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [JsonProperty("extend_params")]
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 付款支付宝用户登录ID
        /// </summary>
        [JsonProperty("login_id")]
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 付款支付宝用户登录密码
        /// </summary>
        [JsonProperty("login_passwd")]
        [XmlElement("login_passwd")]
        public string LoginPasswd { get; set; }

        /// <summary>
        /// 外部商户异步通知地址
        /// </summary>
        [JsonProperty("mc_notify_url")]
        [XmlElement("mc_notify_url")]
        public string McNotifyUrl { get; set; }

        /// <summary>
        /// 商户网站唯一订单号
        /// </summary>
        [JsonProperty("out_trade_no")]
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 外部商户ID
        /// </summary>
        [JsonProperty("partner_id")]
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 付款支付宝用户支付密码
        /// </summary>
        [JsonProperty("pay_passwd")]
        [XmlElement("pay_passwd")]
        public string PayPasswd { get; set; }

        /// <summary>
        /// 销售产品码，商家和支付宝签约的产品码
        /// </summary>
        [JsonProperty("product_code")]
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 收款支付宝用户ID。 如果该值为空，则默认为商户签约账号对应的支付宝用户ID
        /// </summary>
        [JsonProperty("seller_id")]
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 商品的标题/交易标题/订单标题/订单关键字等。
        /// </summary>
        [JsonProperty("subject")]
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 该笔订单的资金总额，单位为RMB-Yuan。取值范围为[0.01，100000000.00]，精确到小数点后两位。
        /// </summary>
        [JsonProperty("total_fee")]
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }

        /// <summary>
        /// 付款支付宝用户ID
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
