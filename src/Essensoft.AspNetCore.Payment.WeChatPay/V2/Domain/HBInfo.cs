using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Domain
{
    /// <summary>
    /// 红包信息
    /// </summary>
    public class HbInfo : WeChatPayObject
    {
        /// <summary>
        /// 领取红包的OpenId
        /// </summary>
        [XmlElement("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 接收时间
        /// </summary>
        [XmlElement("rcv_time")]
        public string RcvTime { get; set; }
    }
}
