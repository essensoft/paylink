using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AccountRecord Data Structure.
    /// </summary>
    [Serializable]
    public class AccountRecord : AlipayObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonProperty("alipay_order_no")]
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 当时账户的余额
        /// </summary>
        [JsonProperty("balance")]
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonProperty("business_type")]
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time")]
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 收入金额
        /// </summary>
        [JsonProperty("in_amount")]
        [XmlElement("in_amount")]
        public string InAmount { get; set; }

        /// <summary>
        /// 账务备注说明
        /// </summary>
        [JsonProperty("memo")]
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("merchant_order_no")]
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 对方支付宝账户ID
        /// </summary>
        [JsonProperty("opt_user_id")]
        [XmlElement("opt_user_id")]
        public string OptUserId { get; set; }

        /// <summary>
        /// 支出金额
        /// </summary>
        [JsonProperty("out_amount")]
        [XmlElement("out_amount")]
        public string OutAmount { get; set; }

        /// <summary>
        /// 本方支付宝账户ID
        /// </summary>
        [JsonProperty("self_user_id")]
        [XmlElement("self_user_id")]
        public string SelfUserId { get; set; }

        /// <summary>
        /// 账务类型
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
