using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.JDPay
{
    public abstract class JDPayResponse : JDPayObject
    {
        /// <summary>
        /// 原始内容
        /// </summary>
        [XmlIgnore]
        public string Body { get; set; }

        /// <summary>
        /// 加密报文
        /// </summary>
        [XmlElement("encrypt")]
        public string Encrypt { get; set; }
    }
}
