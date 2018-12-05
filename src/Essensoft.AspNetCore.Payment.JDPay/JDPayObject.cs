using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.JDPay
{
    /// <summary>
    /// JDPay 基础对象。
    /// </summary>
    public abstract class JDPayObject
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
