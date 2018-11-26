using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PaymentAbilityPostbackResponse Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentAbilityPostbackResponse : AlipayObject
    {
        /// <summary>
        /// 错误的订单信息
        /// </summary>
        [JsonProperty("error_order")]
        [XmlElement("error_order")]
        public string ErrorOrder { get; set; }

        /// <summary>
        /// 成功的订单列表,逗号分隔
        /// </summary>
        [JsonProperty("order_ids")]
        [XmlElement("order_ids")]
        public string OrderIds { get; set; }
    }
}
