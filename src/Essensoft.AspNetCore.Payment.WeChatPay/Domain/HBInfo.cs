using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Domain
{
    public class HBInfo
    {
        /// <summary>
        /// 领取红包的Openid
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
