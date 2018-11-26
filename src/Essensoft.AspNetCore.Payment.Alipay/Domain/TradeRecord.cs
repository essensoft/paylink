using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TradeRecord Data Structure.
    /// </summary>
    [Serializable]
    public class TradeRecord : AlipayObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonProperty("alipay_order_no")]
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonProperty("create_time")]
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 资金流入流程类型,in表示收入,out表示支出
        /// </summary>
        [JsonProperty("in_out_type")]
        [XmlElement("in_out_type")]
        public string InOutType { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("merchant_order_no")]
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 订单最后修改时间
        /// </summary>
        [JsonProperty("modified_time")]
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 对方支付宝登录号，需要隐藏
        /// </summary>
        [JsonProperty("opposite_logon_id")]
        [XmlElement("opposite_logon_id")]
        public string OppositeLogonId { get; set; }

        /// <summary>
        /// 对方姓名，需要隐藏
        /// </summary>
        [JsonProperty("opposite_name")]
        [XmlElement("opposite_name")]
        public string OppositeName { get; set; }

        /// <summary>
        /// 对方支付宝账号
        /// </summary>
        [JsonProperty("opposite_user_id")]
        [XmlElement("opposite_user_id")]
        public string OppositeUserId { get; set; }

        /// <summary>
        /// 订单来源，为空查询所有来源。淘宝(taobao)，支付宝(alipay)，其它(other)
        /// </summary>
        [JsonProperty("order_from")]
        [XmlElement("order_from")]
        public string OrderFrom { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [JsonProperty("order_status")]
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单的名称，描述订单的摘要信息，如交易的商品名称
        /// </summary>
        [JsonProperty("order_title")]
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [JsonProperty("order_type")]
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 本方支付宝登录号，需要隐藏
        /// </summary>
        [JsonProperty("owner_logon_id")]
        [XmlElement("owner_logon_id")]
        public string OwnerLogonId { get; set; }

        /// <summary>
        /// 本方姓名，需要隐藏
        /// </summary>
        [JsonProperty("owner_name")]
        [XmlElement("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 本方支付宝账号
        /// </summary>
        [JsonProperty("owner_user_id")]
        [XmlElement("owner_user_id")]
        public string OwnerUserId { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonProperty("partner_id")]
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 订单服务费
        /// </summary>
        [JsonProperty("service_charge")]
        [XmlElement("service_charge")]
        public string ServiceCharge { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [JsonProperty("total_amount")]
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
