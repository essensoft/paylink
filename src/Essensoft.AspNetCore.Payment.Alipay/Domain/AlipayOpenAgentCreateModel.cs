using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAgentCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAgentCreateModel : AlipayObject
    {
        /// <summary>
        /// isv代操作的商户账号，可以是支付宝账号，也可以是pid（2088开头）
        /// </summary>
        [JsonProperty("account")]
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 商户联系人信息，包含联系人名称、手机、邮箱信息。联系人信息将用于接受签约后的重要通知，如确认协议、到期提醒等。
        /// </summary>
        [JsonProperty("contact_info")]
        [XmlElement("contact_info")]
        public ContactModel ContactInfo { get; set; }

        /// <summary>
        /// 订单授权凭证，填写都则对应事务提交进入预授权模式
        /// </summary>
        [JsonProperty("order_ticket")]
        [XmlElement("order_ticket")]
        public string OrderTicket { get; set; }
    }
}
