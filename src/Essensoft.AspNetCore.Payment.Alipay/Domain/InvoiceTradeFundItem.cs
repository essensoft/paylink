using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceTradeFundItem Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceTradeFundItem : AlipayObject
    {
        /// <summary>
        /// 当前支付工具支付的金额
        /// </summary>
        [JsonProperty("amount")]
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝支付工具描述
        /// </summary>
        [JsonProperty("payment_tool_name")]
        [XmlElement("payment_tool_name")]
        public string PaymentToolName { get; set; }

        /// <summary>
        /// 支付宝支付工具类型
        /// </summary>
        [JsonProperty("payment_tool_type")]
        [XmlElement("payment_tool_type")]
        public string PaymentToolType { get; set; }
    }
}
